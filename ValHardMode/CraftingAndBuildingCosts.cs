using HarmonyLib;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ObjectDB), "Awake")]
    public static class RecipePatchAwake
    {
        private static void Postfix()
        {
            if (Configuration.Current.IsEnabled)
            {
                UpdateReqs.UpdateRecipes(ObjectDB.instance);
            }
        }
    }

    [HarmonyPatch(typeof(ObjectDB), "CopyOtherDB")]
    public static class RecipePatchCopyOtherDB
    {
        private static void Postfix(ref ObjectDB __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                UpdateReqs.UpdateRecipes(__instance);
            }
        }
    }

    [HarmonyPatch(typeof(InventoryGui), "UpdateCraftingPanel")]
    public static class RecipeCosts
    {
        private static void Postfix()
        {
            if (Configuration.Current.IsEnabled)
            {
                UpdateReqs.UpdateRecipes(ObjectDB.instance);
            }
        }
    }

    [HarmonyPatch(typeof(Player), "GetPiece")]
    public static class BuildingCosts
    {
        private static void Postfix(ref Player __instance, ref Piece __result)
        {
            if (Configuration.Current.IsEnabled && __result != null)
            {
                // Update Piece requirements
                foreach (Configuration.PieceOverride craftOverride in Configuration.Current.PieceOverrides)
                {
                    if (__result.m_name == craftOverride.Name)
                    {
                        __result.m_resources = UpdateReqs.Update(__result.m_resources, craftOverride.Requirements);
                        break;
                    }
                }
            }
        }
    }

    public static class UpdateReqs
    {
        public static void UpdateRecipes(ObjectDB objDB)
        {
            // Update recipe requirements
            foreach (Recipe recipe in objDB.m_recipes)
            {
                if (recipe.m_item == null)
                    continue;

                if (recipe.name == "Recipe_SwordFire")
                {
                    recipe.m_enabled = true;
                    recipe.m_minStationLevel = 4;
                }

                foreach (Configuration.RecipeOverride recipeOverride in Configuration.Current.RecipeOverrides)
                {
                    if (recipe.name == recipeOverride.Name)
                    {
                        recipe.m_resources = UpdateReqs.Update(recipe.m_resources, recipeOverride.Requirements);
                    }
                }
            }
        }

        public static Piece.Requirement[] Update(Piece.Requirement[] originalReqs, Configuration.OverrideReq[] overrideReqs)
        {
            List<Configuration.OverrideReq> updatedReqs = new List<Configuration.OverrideReq>();
            List<Piece.Requirement> newReqs = new List<Piece.Requirement>();

            foreach (Piece.Requirement req in originalReqs)
            {
                bool remove = false;
                foreach (Configuration.OverrideReq reqOverride in overrideReqs)
                {
                    // Update exisiting requirement values
                    if (req.m_resItem.m_itemData.m_shared.m_name == reqOverride.Name)
                    {
                        if (reqOverride.Remove)
                        {
                            remove = true;
                        }
                        else
                        {
                            if (reqOverride.AmountIsSet)
                                req.m_amount = reqOverride.Amount;
                            if (reqOverride.AmountPerLevelIsSet)
                                req.m_amountPerLevel = reqOverride.AmountPerLevel;
                            if (reqOverride.RecoverIsSet)
                                req.m_recover = reqOverride.Recover;
                        }

                        updatedReqs.Add(reqOverride);
                        break;
                    }
                }

                if (!remove)
                    newReqs.Add(req);
            }

            if (overrideReqs.Length != updatedReqs.Count)
            {
                foreach (Configuration.OverrideReq reqOverride in overrideReqs)
                {
                    ItemDrop item = ObjectDBWrapper.GetItem(reqOverride.Name);
                    if (item == null)
                    {
                        ZLog.LogWarning("Did not find requirement item: " + reqOverride.Name);
                    }
                    else if (!updatedReqs.Contains(reqOverride)
                        && !reqOverride.Remove
                        && reqOverride.AmountIsSet 
                        && reqOverride.AmountPerLevelIsSet 
                        && reqOverride.RecoverIsSet 
                        && !String.IsNullOrEmpty(reqOverride.Name))
                    {
                        // Create new requirement
                        newReqs.Add(new Piece.Requirement()
                        {
                            m_amount = reqOverride.Amount,
                            m_amountPerLevel = reqOverride.AmountPerLevel,
                            m_recover = reqOverride.Recover,
                            m_resItem = item
                        });
                    }
                }
            }

            return newReqs.ToArray();
        }
    }

    public static class ObjectDBWrapper
    {
        public static ItemDrop GetItem(string name)
        {
            foreach (GameObject gameObject in ObjectDB.instance.m_items)
            {
                ItemDrop component = gameObject.GetComponent<ItemDrop>();
                if (component.m_itemData.m_shared.m_name == name)
                    return component;
            }
            return null;
        }
    }
}
