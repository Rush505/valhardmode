using HarmonyLib;
using System;
using UnityEngine;

namespace ValHardMode
{
    [HarmonyPatch(typeof(CraftingStation), "Start")]
    public static class CraftingStationBuildRange
    {
        private static void Postfix(ref CraftingStation __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                try
                {
                    __instance.m_rangeBuild = __instance.m_rangeBuild * Configuration.Current.CraftingStationBuildRangeFactor;
                    __instance.m_areaMarker.GetComponent<CircleProjector>().m_radius = __instance.m_rangeBuild;
                    float scaleIncrease = (__instance.m_rangeBuild - 20f) / 20f * 100f;
                    __instance.m_areaMarker.gameObject.transform.localScale = new Vector3(scaleIncrease / 100, 1f, scaleIncrease / 100);
                }
                catch (Exception)
                {}
            }
        }
    }
}
