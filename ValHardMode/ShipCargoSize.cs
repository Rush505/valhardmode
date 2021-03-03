using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Ship), "Awake")]
    public static class ShipCargoSize
    {
        private static void Postfix(ref Ship __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                Container container = __instance.gameObject.transform.GetComponentInChildren<Container>();
                if (container != null)
                {
                    container.m_width = Configuration.Current.KarveCargoSlotsWidth;
                }
            }
        }
    }
}