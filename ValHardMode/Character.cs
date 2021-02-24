using HarmonyLib;
using BepInEx;
using UnityEngine;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Character), "Awake")]
    public static class IncreasedEnemyHealth
    {
        private static void Postfix(ref Character __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                // Increase regular enemy health
                if (!__instance.IsBoss() && __instance.IsMonsterFaction())
                {
                    __instance.SetMaxHealth(__instance.GetMaxHealth() * 2.0f);
                }

                // Increase boss health
                if (__instance.IsBoss())
                {
                    __instance.SetMaxHealth(__instance.GetMaxHealth() * 1.5f);
                }
            }
        }
    }
}
