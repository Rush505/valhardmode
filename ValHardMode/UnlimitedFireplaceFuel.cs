using HarmonyLib;
using BepInEx;
using UnityEngine;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Fireplace), "UpdateFireplace")]
    public static class UnlimitedFireplaceFuel
    {
        private static void Postfix(ref Fireplace __instance, ref ZNetView ___m_nview)
        {
            if (Configuration.Current.IsEnabled)
            {
                ___m_nview.GetZDO().Set("fuel", __instance.m_maxFuel - 1);
            }
        }
    }
}