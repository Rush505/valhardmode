using HarmonyLib;
using BepInEx;
using UnityEngine;

namespace ValHardMode
{
    [HarmonyPatch(typeof(CraftingStation), "Start")]
    public static class CraftingStationRange
    {
        private static void Postfix(ref CraftingStation __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                // Double use range for crafting stations
                __instance.m_useDistance = __instance.m_useDistance * 2;
            }
        }
    }
}