using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Character), "IsSwiming")]
    public static class AllowItemsWhileSwimming
    {
        static bool Prefix(Humanoid __instance, ref bool __result)
        {
            if (Configuration.Current.IsEnabled)
            {
                string callingMethod = (new System.Diagnostics.StackTrace()).GetFrame(2).GetMethod().Name;
                if ((callingMethod == "DMD<Humanoid::EquipItem>" || callingMethod == "UpdateEquipment") && __instance.IsPlayer())
                {
                    __result = false;
                    return false; // Don't call underlying method
                }
            }

            return true;
        }
    }
}
