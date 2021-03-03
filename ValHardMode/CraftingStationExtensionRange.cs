using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(StationExtension), "Awake")]
    public static class CraftingStationExtensionRange
    {
        private static void Postfix(ref StationExtension __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                __instance.m_maxStationDistance = Configuration.Current.MaxStationExtensionDistance;
            }
        }
    }
}