using HarmonyLib;
using BepInEx;
using UnityEngine;

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
                    // Increase regular enemy health
                    __instance.SetMaxHealth(__instance.GetMaxHealth() * 1.5f);
                }
                
                if (__instance.IsBoss())
                {
                    if (__instance.m_bossEvent == "boss_eikthyr")
                    {
                        // Increase Eikthyr move speed
                        __instance.m_walkSpeed = __instance.m_walkSpeed * 50;
                        __instance.m_runSpeed = __instance.m_runSpeed * 100;
                        __instance.m_turnSpeed = __instance.m_turnSpeed * 10;
                        __instance.m_staggerWhenBlocked = false;
                    }
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
                if (__instance.m_itemData.m_shared.m_name == "Eikthyr_stomp" || __instance.m_itemData.m_shared.m_name == "Eikthyr_charge")
                {
                    // Increase Eikthyr special attack damage and prevent blocking
                    __instance.m_itemData.m_shared.m_damages.m_lightning += 5f;
                    __instance.m_itemData.m_shared.m_blockable = false;
                }
            }
        }
    }
}