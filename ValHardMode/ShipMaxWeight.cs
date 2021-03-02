using HarmonyLib;
using UnityEngine;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Ship), "FixedUpdate")]
    public static class ShipWeightMass
    {
        private static void Postfix(ref Ship __instance, ref Rigidbody ___m_body)
        {
            if (Configuration.Current.IsEnabled)
            {
                Container container = __instance.gameObject.transform.GetComponentInChildren<Container>();
                if (container != null)
                {
                    float maxWeight = 1000;
                    if (__instance.name.ToLower().Contains("karve"))
                        maxWeight = Configuration.Current.KarveWeightMax;
                    else if (__instance.name.ToLower().Contains("vikingship"))
                        maxWeight = Configuration.Current.LongshipWeightMax;

                    float containerWeight = container.GetInventory().GetTotalWeight();

                    if (containerWeight > maxWeight)
                    {
                        float weightForce = (containerWeight - maxWeight) / maxWeight;
                        ___m_body.AddForceAtPosition(Vector3.down * weightForce * 5, ___m_body.worldCenterOfMass, (ForceMode)2);
                    }
                }
            }
        }
    }

    [HarmonyPatch(typeof(InventoryGui), "UpdateContainerWeight")]
    public static class ShipMaxWeightChanged
    {
        private static void Postfix(ref InventoryGui __instance, ref Container ___m_currentContainer)
        {
            if (Configuration.Current.IsEnabled)
            {
                if (___m_currentContainer == null)
                    return;

                Ship ship = ___m_currentContainer.gameObject.transform.parent?.GetComponent<Ship>();
                if (ship != null)
                {
                    float maxWeight = 1000;
                    if (ship.name.ToLower().Contains("karve"))
                        maxWeight = Configuration.Current.KarveWeightMax;
                    else if (ship.name.ToLower().Contains("vikingship"))
                        maxWeight = Configuration.Current.LongshipWeightMax;

                    int totalWeight = Mathf.CeilToInt(___m_currentContainer.GetInventory().GetTotalWeight());

                    if (totalWeight > maxWeight && (double)Mathf.Sin(Time.time * 10f) > 0.0)
                        __instance.m_containerWeight.text = "<color=red>" + totalWeight.ToString() + "</color>/" + maxWeight.ToString();
                    else
                        __instance.m_containerWeight.text = totalWeight.ToString() + "/" + maxWeight.ToString();
                }
            }
        }
    }
}