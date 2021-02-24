using HarmonyLib;
using BepInEx;
using UnityEngine;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Smelter), "Awake")]
    public static class IncreasedSmelterCapacity
    {
        private static void Postfix(ref Smelter __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                // Increase capacity of smelter objects
                __instance.m_maxFuel = __instance.m_maxFuel * 5;
                __instance.m_maxOre = __instance.m_maxOre * 5;
            }
        }
    }
}
