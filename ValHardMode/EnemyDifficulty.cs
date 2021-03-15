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
                // Increase normal enemy health
                if (!__instance.IsBoss() && __instance.IsMonsterFaction())
                {
                    __instance.SetMaxHealth(__instance.m_health * Game.instance.GetDifficultyHealthScale(((Component)__instance).transform.position) * (float)__instance.GetLevel() * Configuration.Current.NonBossEnemyMaxHealthFactor);
                }

                // Increase boss health
                if (__instance.IsBoss())
                {
                    __instance.SetMaxHealth(__instance.m_health * Game.instance.GetDifficultyHealthScale(((Component)__instance).transform.position) * (float)__instance.GetLevel() * Configuration.Current.BossMaxHealthFactor);
                }
                
                if (__instance.m_name == "$enemy_troll")
                {
                    // Troll speed changes
                    __instance.m_walkSpeed *= Configuration.Current.TrollMovementSpeedFactor;
                    __instance.m_runSpeed *= Configuration.Current.TrollMovementSpeedFactor;
                    __instance.m_turnSpeed *= Configuration.Current.TrollMovementSpeedFactor;
                }
                else if (__instance.m_name == "$enemy_eikthyr")
                {
                    // Eikthyr speed changes
                    __instance.m_walkSpeed *= Configuration.Current.EikthyrMovementSpeedFactor;
                    __instance.m_runSpeed *= Configuration.Current.EikthyrMovementSpeedFactor;
                    __instance.m_turnSpeed *= Configuration.Current.EikthyrMovementSpeedFactor;
                }
                else if (__instance.m_name == "$enemy_gdking")
                {
                    // Elder speed changes
                    __instance.m_walkSpeed *= Configuration.Current.ElderMovementSpeedFactor;
                    __instance.m_runSpeed *= Configuration.Current.ElderMovementSpeedFactor;
                    __instance.m_turnSpeed *= Configuration.Current.ElderMovementSpeedFactor;
                    __instance.m_runTurnSpeed *= Configuration.Current.ElderMovementSpeedFactor;
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
                    // Increase all enemy damage (except poison)
                    __instance.m_itemData.m_shared.m_damages.m_lightning *= Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_damages.m_fire *= Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_damages.m_spirit *= Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_damages.m_damage *= Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_damages.m_chop *= Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_damages.m_slash *= Configuration.Current.EnemyAttackDamageFactor;
                    __instance.m_itemData.m_shared.m_damages.m_blunt *= Configuration.Current.EnemyAttackDamageFactor;

                    __instance.m_itemData.m_shared.m_attack.m_speedFactor = Configuration.Current.EnemyAttackSpeedFactor;

                    __instance.m_itemData.m_shared.m_aiAttackInterval *= Configuration.Current.EnemyAttackIntervalFactor;
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
                // Enemy minimum attack
                __instance.m_minAttackInterval *= Configuration.Current.EnemyAttackMinIntervalFactor;
            }
        }
    }

    [HarmonyPatch(typeof(SpawnArea), "Awake")]
    public static class IncreaseMobLevelChance
    {
        private static void Postfix(ref SpawnArea __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                // Increase the chance for higher level mobs
                __instance.m_levelupChance *= Configuration.Current.EnemyLevelUpChanceFactor;
                __instance.m_maxTotal *= Configuration.Current.EnemySpawnAmountFactor;
            }
        }
    }

    //[HarmonyPatch(typeof(LevelEffects), "SetupLevelVisualization")]
    //public static class IncreaseMobSizeOnLevels
    //{
    //    private static void Prefix(int level, ref LevelEffects __instance)
    //    {
    //        if (Configuration.Current.IsEnabled)
    //        {
    //            // Increase size of higher level mobs
    //            if (level <= 1 || __instance.m_levelSetups.Count < level - 1)
    //                return;

    //            __instance.m_levelSetups[level - 2].m_scale = __instance.m_levelSetups[level - 2].m_scale * (1 + (Configuration.Current.EnemyLevelSizeIncreaseFactor * (level - 1)));
    //        }
    //    }
    //}

    //[HarmonyPatch(typeof(Humanoid), "OnRagdollCreated")]
    //public static class IncreaseMobRagdollSizeOnLevels
    //{
    //    private static void Postfix(Ragdoll ragdoll, Humanoid __instance)
    //    {
    //        if (Configuration.Current.IsEnabled)
    //        {
    //            // Increase ragdoll size of higher level mobs
    //            int lvl = __instance.GetLevel();
    //            if (lvl <= 1)
    //                return;

    //            float scale = 1 + (Configuration.Current.EnemyLevelSizeIncreaseFactor * (lvl - 1));
    //            ragdoll.transform.localScale = new Vector3(scale, scale, scale);
    //        }
    //    }
    //}

    [HarmonyPatch(typeof(BaseAI), "Awake")]
    public static class RemoveFearOfFire
    {
        private static void Postfix(ref BaseAI __instance)
        {
            if (Configuration.Current.IsEnabled && Configuration.Current.RemoveEnemyFireAvoid)
            {
                __instance.m_afraidOfFire = false;
                __instance.m_avoidFire = false;
            }
        }
    }
}