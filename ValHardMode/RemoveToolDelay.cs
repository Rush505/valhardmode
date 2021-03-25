using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch]
    public static class RemoveToolDelay
    {
        [HarmonyPatch(typeof(Player), "Awake")]
        [HarmonyPostfix]
        private static void OverwriteToolDelay(ref Player __instance)
        {
            if (!Configuration.Current.IsEnabled)
                return;

            __instance.m_toolUseDelay = 0;
        }
    }
}