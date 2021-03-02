using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ZDOMan), "SendZDOs")]
    public static class ChangeDataRate
    {
        private static void Prefix(ref ZDOMan __instance, ref int ___m_dataPerSec)
        {
            // If we dont limit this to a reasonable value you will get packet pipe problems
            if (Configuration.Current.DataRateOverride > 512) Configuration.Current.DataRateOverride = 512;

            if (Configuration.Current.IsEnabled && Configuration.Current.DataRateOverride >= 60)
            {
                ___m_dataPerSec = Configuration.Current.DataRateOverride * 1024;
            }
        }
    }
}