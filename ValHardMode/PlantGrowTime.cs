using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Plant), "Awake")]
    public static class PlantGrowTime
    {
        private static void Postfix(ref Plant __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                if (__instance.m_name == "$prop_beech_sapling"
                    || __instance.m_name == "$prop_pine_sapling"
                    || __instance.m_name == "$prop_fir_sapling")
                {
                    __instance.m_growTime = __instance.m_growTime * Configuration.Current.TreeGrowSpeedFactor;
                    __instance.m_growTimeMax = __instance.m_growTimeMax * Configuration.Current.TreeGrowSpeedFactor;
                }
            }
        }
    }
}
