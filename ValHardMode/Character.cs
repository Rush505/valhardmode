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
            if (!__instance.IsBoss() && __instance.IsMonsterFaction())
            {
                __instance.SetMaxHealth(__instance.GetMaxHealth() * 2.0f);
            }

            if (__instance.IsBoss())
            {
                __instance.SetMaxHealth(__instance.GetMaxHealth() * 1.5f);
            }
        }
    }
}
