using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Ship), "Awake")]
    public static class ShipDamage
    {
        private static void Postfix(ref Ship __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                // Increase ship damage take from waves and reduce min interval
                __instance.m_waterImpactDamage = __instance.m_waterImpactDamage * 2f;
                __instance.m_minWaterImpactInterval = __instance.m_minWaterImpactInterval * .5f;

                // Increase upside down damage
                __instance.m_upsideDownDmg = __instance.m_upsideDownDmg * 2.5f;
            }
        }
    }
}
