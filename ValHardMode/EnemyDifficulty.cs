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
                    __instance.SetMaxHealth(__instance.GetMaxHealth() * 2.0f);
                }

                
                if (__instance.IsBoss())
                {
                    if (__instance.m_bossEvent != "boss_bonemass")
                    {
                        // Increase boss health
                        __instance.SetMaxHealth(__instance.GetMaxHealth() * 1.5f);
                    }

                    if (__instance.m_bossEvent == "boss_eikthyr")
                    {
                        // Increase Eikthyr speed
                        __instance.m_walkSpeed = __instance.m_walkSpeed * 50;
                        __instance.m_runSpeed = __instance.m_runSpeed * 100;
                        __instance.m_turnSpeed = __instance.m_turnSpeed * 10;
                        __instance.m_staggerWhenBlocked = false;

                        // Increase Eikthyr damage
                        //TODO
                    }
                }
            }
        }
    }
}
