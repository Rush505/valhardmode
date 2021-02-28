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
            // Cache item drops for materials
            var uniqueReqs = Configuration.Current.PieceOverrides.SelectMany(x => x.Requirements).Select(y => y.Name).Distinct().ToList();
            SharedItems.AllItems.Clear();
            foreach (GameObject gameObject in ObjectDB.instance.m_items)
            {
                ItemDrop component = gameObject.GetComponent<ItemDrop>();
                if (uniqueReqs.Contains(component.m_itemData.m_shared.m_name))
                {
                    SharedItems.AllItems.Add(new SharedItems.CachedItem()
                    {
                        Name = component.m_itemData.m_shared.m_name,
                        GameItemDrop = component
                    });
                }
            }
        }
    }

    [HarmonyPatch(typeof(ObjectDB), "CopyOtherDB")]
    public static class RecipePatchCopyOtherDB
    {
        private static void Postfix(ref List<Recipe> ___m_recipes)
        {
            if (Configuration.Current.IsEnabled)
            {
                // Update recipe requirements
                foreach (Recipe recipe in ___m_recipes)
                {
                    if (recipe.m_item == null)
                        continue;

                    foreach (Configuration.RecipeOverride recipeOverride in Configuration.Current.RecipeOverrides)
                    {
                        if (recipe.name == recipeOverride.Name)
                        {
                            ZLog.Log("Attempting to modify recipe: " + recipeOverride.Name);
                            recipe.m_resources = UpdateReqs.Update(recipe.m_resources, recipeOverride.Requirements);
                            break;
                        }
                    }
                }
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
                // Update recipe requirements
                foreach (Recipe recipe in ObjectDB.instance.m_recipes)
                {
                    if (recipe.m_item == null)
                        continue;

                    foreach (Configuration.RecipeOverride recipeOverride in Configuration.Current.RecipeOverrides)
                    {
                        if (recipe.name == recipeOverride.Name)
                        {
                            ZLog.Log("Attempting to modify recipe: " + recipeOverride.Name);
                            recipe.m_resources = UpdateReqs.Update(recipe.m_resources, recipeOverride.Requirements);
                        }
                    }
                }
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
                        ZLog.Log("Attempting to modify piece: " + craftOverride.Name);
                        __result.m_resources = UpdateReqs.Update(__result.m_resources, craftOverride.Requirements);
                        break;
                    }
                }
            }
        }
    }

    public static class ForceUpdateReqs
    {
        public static void Update()
        {
            // Update recipe requirements
            foreach (Recipe recipe in ObjectDB.instance.m_recipes)
            {
                if (recipe.m_item == null)
                    continue;

                foreach (Configuration.RecipeOverride recipeOverride in Configuration.Current.RecipeOverrides)
                {
                    if (recipe.name == recipeOverride.Name)
                    {
                        ZLog.Log("Attempting to modify recipe: " + recipeOverride.Name);
                        recipe.m_resources = UpdateReqs.Update(recipe.m_resources, recipeOverride.Requirements);
                    }
                }
            }
        }
    }

    public static class UpdateReqs
    {
        public static Piece.Requirement[] Update(Piece.Requirement[] originalReqs, Configuration.OverrideReq[] overrideReqs)
        {
            List<Configuration.OverrideReq> updatedReqs = new List<Configuration.OverrideReq>();
            List<Piece.Requirement> newReqs = new List<Piece.Requirement>();

            foreach (Piece.Requirement req in originalReqs)
            {
                foreach (Configuration.OverrideReq reqOverride in overrideReqs)
                {
                    // Update exisiting requirement values
                    if (req.m_resItem.m_itemData.m_shared.m_name == reqOverride.Name)
                    {
                        ZLog.Log("Updating requirement: " + reqOverride.Name);
                        if (reqOverride.AmountIsSet)
                            req.m_amount = reqOverride.Amount;
                        if (reqOverride.AmountPerLevelIsSet)
                            req.m_amountPerLevel = reqOverride.AmountPerLevel;
                        if (reqOverride.RecoverIsSet)
                            req.m_recover = reqOverride.Recover;
                        updatedReqs.Add(reqOverride);
                        break;
                    }
                }

                newReqs.Add(req);
            }

            if (updatedReqs.Count != overrideReqs.Length)
            {
                ZLog.Log("Adding new requirements");
                foreach (Configuration.OverrideReq reqOverride in overrideReqs)
                {
                    if (!updatedReqs.Contains(reqOverride)
                        && reqOverride.AmountIsSet && reqOverride.AmountPerLevelIsSet && reqOverride.RecoverIsSet && !String.IsNullOrEmpty(reqOverride.Name)
                        && SharedItems.AllItems.Where(x => x.Name == reqOverride.Name).Count() > 0)
                    {
                        // Create new requirement
                        ZLog.Log("Adding requirement: " + reqOverride.Name);
                        newReqs.Add(new Piece.Requirement()
                        {
                            m_amount = reqOverride.Amount,
                            m_amountPerLevel = reqOverride.AmountPerLevel,
                            m_recover = reqOverride.Recover,
                            m_resItem = SharedItems.AllItems.Where(x => x.Name == reqOverride.Name).First().GameItemDrop
                        });
                    }
                }
            }

            return newReqs.ToArray();
        }
    }

    public static class SharedItems
    {
        public static List<CachedItem> AllItems = new List<CachedItem>();

        public class CachedItem
        {
            public string Name;
            public ItemDrop GameItemDrop;
        }
    }
}
