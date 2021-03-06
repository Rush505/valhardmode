using HarmonyLib;
using System;
using System.Collections.Generic;

namespace ValHardMode
{
    [HarmonyPatch(typeof(CharacterDrop), "Start")]
    public static class DropRateOverrides
    {
        private static void Postfix(ref CharacterDrop __instance, ref Character ___m_character)
        {
            if (Configuration.Current.IsEnabled)
            {
                foreach (Configuration.EnemyDropOverride enemyDropOverride in Configuration.Current.EnemyDropOverrides)
                {
                    if (___m_character.m_name == enemyDropOverride.Name)
                    {
                        ZLog.Log("Overriding enemy drops " + enemyDropOverride.Name);
                        __instance.m_drops = UpdateDrops.Update(__instance.m_drops, enemyDropOverride.Drops);
                    }
                }
            }
        }
    }

    [HarmonyPatch(typeof(Character), "GetLevel")]
    public static class CapEnemyLootLevel
    {
        private static bool Prefix(ref Character __instance, int ___m_level, ref int __result)
        {
            string callingMethod = (new System.Diagnostics.StackTrace()).GetFrame(2).GetMethod().Name;
            if (callingMethod == "GenerateDropList"
                && !__instance.IsPlayer()
                && !__instance.IsBoss()
                && !__instance.IsTamed())
            {
                __result = Math.Min(___m_level, Configuration.Current.MaxLevelEnemyDrops);
                return false; // Don't call underlying method
            }

            return true;
        }
    }

    public static class UpdateDrops
    {
        public static List<CharacterDrop.Drop> Update(List<CharacterDrop.Drop> originalDrops, Configuration.DropOverride[] overrideDrops)
        {
            List<Configuration.DropOverride> updatedDrops = new List<Configuration.DropOverride>();
            List<CharacterDrop.Drop> newDrops = new List<CharacterDrop.Drop>();

            foreach (CharacterDrop.Drop drop in originalDrops)
            {
                bool remove = false;
                foreach (Configuration.DropOverride dropOverride in overrideDrops)
                {
                    // Update existing values
                    ItemDrop iDrop = drop.m_prefab.GetComponent<ItemDrop>();
                    if (iDrop == null)
                    {
                        ZLog.LogWarning("Could not get drop item for " + dropOverride.ItemName);
                        break;
                    }

                    if (iDrop.m_itemData.m_shared.m_name == dropOverride.ItemName)
                    {
                        if (dropOverride.Remove)
                        {
                            remove = true;
                        }
                        else
                        {
                            if (dropOverride.AmountMaxIsSet)
                                drop.m_amountMax = dropOverride.AmountMax;
                            if (dropOverride.AmountMinIsSet)
                                drop.m_amountMin = dropOverride.AmountMin;
                            if (dropOverride.ChanceIsSet)
                                drop.m_chance = dropOverride.Chance;
                            if (dropOverride.LevelMultiplierIsSet)
                                drop.m_levelMultiplier = dropOverride.LevelMultiplier;
                            if (dropOverride.OnePerPlayerIsSet)
                                drop.m_onePerPlayer = dropOverride.OnePerPlayer;
                        }

                        updatedDrops.Add(dropOverride);
                        break;
                    }
                }

                if (!remove)
                    newDrops.Add(drop);
            }

            if (overrideDrops.Length != updatedDrops.Count)
            {
                foreach (Configuration.DropOverride dropOverride in overrideDrops)
                {
                    ItemDrop item = ObjectDBWrapper.GetItem(dropOverride.ItemName);
                    if (item == null)
                    {
                        ZLog.LogWarning("Could not find drop item for override: " + dropOverride.ItemName);
                        break;
                    }

                    if (!updatedDrops.Contains(dropOverride)
                        && !dropOverride.Remove
                        && dropOverride.AmountMaxIsSet
                        && dropOverride.AmountMinIsSet
                        && dropOverride.ChanceIsSet
                        && dropOverride.LevelMultiplierIsSet
                        && dropOverride.OnePerPlayerIsSet)
                    {
                        // Create new requirement
                        newDrops.Add(new CharacterDrop.Drop()
                        {
                            m_amountMax = dropOverride.AmountMax,
                            m_amountMin = dropOverride.AmountMin,
                            m_chance = dropOverride.Chance,
                            m_levelMultiplier = dropOverride.LevelMultiplier,
                            m_onePerPlayer = dropOverride.OnePerPlayer,
                            m_prefab = item.gameObject
                        });
                    }
                }
            }

            return newDrops;
        }
    }
}
