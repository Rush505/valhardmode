using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Ship), "Awake")]
    public static class BoatDamage
    {
        private static void Postfix(ref Ship __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                // Increase ship damage take from waves and min frequency
                __instance.m_minWaterImpactForce = __instance.m_minWaterImpactForce * .8f;
                __instance.m_waterImpactDamage = __instance.m_waterImpactDamage * 2.5f;
                __instance.m_minWaterImpactInterval = __instance.m_minWaterImpactInterval * .5f;

                // Increase upside down damage
                __instance.m_upsideDownDmg = __instance.m_upsideDownDmg * 2.5f;
            }
        }
    }
}
