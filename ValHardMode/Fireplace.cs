using HarmonyLib;
using BepInEx;
using UnityEngine;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Fireplace), "UpdateFireplace")]
    public static class UnlimitedFireplaceCapacity
    {
        private static void Postfix(ref Fireplace __instance, ref ZNetView ___m_nview)
        {
            if (Configuration.Current.IsEnabled)
            {
                // Always set current fuel to max
                ___m_nview.GetZDO().Set("fuel", __instance.m_maxFuel);
            }
        }
    }
}
