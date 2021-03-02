using HarmonyLib;
using BepInEx;
using UnityEngine;
using System;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Humanoid), "Awake")]
    public static class EnemyDifficulty
    {
        private static void Postfix(ref Humanoid __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                if (!__instance.IsBoss() && __instance.IsMonsterFaction())
                {
                    __instance.SetMaxHealth(__instance.m_health * Game.instance.GetDifficultyHealthScale(((Component)__instance).transform.position) * (float)__instance.GetLevel());
                    __instance.SetMaxHealth(__instance.GetMaxHealth() * Configuration.Current.NonBossEnemyMaxHealthFactor);
                }

                if (__instance.IsBoss())
                {
                    __instance.SetMaxHealth(__instance.m_health * Game.instance.GetDifficultyHealthScale(((Component)__instance).transform.position) * (float)__instance.GetLevel());
                    __instance.SetMaxHealth(__instance.GetMaxHealth() * Configuration.Current.BossMaxHealthFactor);
                }

                if (__instance.m_name == "$enemy_troll")
                {
                    __instance.m_walkSpeed = __instance.m_walkSpeed * Configuration.Current.TrollMovementSpeedFactor;
                    __instance.m_runSpeed = __instance.m_runSpeed * Configuration.Current.TrollMovementSpeedFactor;
                    __instance.m_turnSpeed = __instance.m_turnSpeed * Configuration.Current.TrollMovementSpeedFactor;
                }
                else if (__instance.m_name == "$enemy_eikthyr")
                {
                    __instance.m_walkSpeed = __instance.m_walkSpeed * Configuration.Current.EikthyrMovementSpeedFactor;
                    __instance.m_runSpeed = __instance.m_runSpeed * Configuration.Current.EikthyrMovementSpeedFactor;
                    __instance.m_turnSpeed = __instance.m_turnSpeed * Configuration.Current.EikthyrMovementSpeedFactor;
                }
                else if (__instance.m_name == "$enemy_gdking")
                {
                    __instance.m_walkSpeed = Configuration.Current.ElderWalkSpeed;
                    __instance.m_runSpeed = Configuration.Current.ElderRunSpeed;
                    __instance.m_turnSpeed = Configuration.Current.ElderTurnSpeed;
                    __instance.m_runTurnSpeed = Configuration.Current.ElderRunTurnSpeed;
                }
            }
        }
    }

    [HarmonyPatch(typeof(ItemDrop), "Awake")]
    public static class EnemyDamage
    {
        private static void Postfix(ref ItemDrop __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                if (!__instance.m_itemData.m_shared.m_name.StartsWith("$item_"))
                {
                    // Increase all non-player abilities
                    __instance.m_itemData.m_shared.m_damages.m_lightning = __instance.m_itemData.m_shared.m_damages.m_lightning * Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_damages.m_damage = __instance.m_itemData.m_shared.m_damages.m_damage * Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_damages.m_chop = __instance.m_itemData.m_shared.m_damages.m_chop * Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_damages.m_slash = __instance.m_itemData.m_shared.m_damages.m_slash * Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_damages.m_blunt = __instance.m_itemData.m_shared.m_damages.m_blunt * Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_attack.m_speedFactor = Configuration.Current.EnemyAttackSpeedFactor;
                    __instance.m_itemData.m_shared.m_aiAttackInterval = __instance.m_itemData.m_shared.m_aiAttackInterval * Configuration.Current.EnemyAttackIntervalFactor;
                }
            }
        }
    }

    [HarmonyPatch(typeof(MonsterAI), "Awake")]
    public static class EnemyAI
    {
        private static void Postfix(ref MonsterAI __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                __instance.m_minAttackInterval = Configuration.Current.EnemyAttackMinInterval;
            }
        }
    }

    [HarmonyPatch(typeof(SpawnArea), "Awake")]
    public static class IncreaseMobLevelChance
    {
        private static void Postfix(ref SpawnArea __instance)
        {
            // Increase the chance for higher level mobs
            if (Configuration.Current.IsEnabled)
            {
                __instance.m_levelupChance = __instance.m_levelupChance * Configuration.Current.EnemyLevelUpChanceFactor;
                __instance.m_maxTotal = __instance.m_maxTotal * Configuration.Current.EnemySpawnAmountFactor;
            }
        }
    }

    [HarmonyPatch(typeof(LevelEffects), "SetupLevelVisualization")]
    public static class IncreaseMobSizeOnLevels
    {
        private static void Prefix(int level, ref LevelEffects __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                if (level <= 1 || __instance.m_levelSetups.Count < level - 1)
                    return;

                __instance.m_levelSetups[level - 2].m_scale = __instance.m_levelSetups[level - 2].m_scale * (1 + (Configuration.Current.EnemyLevelSizeIncreaseFactor * (level - 1)));
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
                && (!__instance.IsTamed() && !Configuration.Current.TamedDropNormalLoot))
            {
                ZLog.Log("Capping enemy drops to level " + Math.Min( ___m_level, Configuration.Current.MaxLevelEnemyDrops));
                __result = Math.Min(___m_level, Configuration.Current.MaxLevelEnemyDrops);
                return false; // Don't call underlying method
            }

            return true;
        }
    }
}