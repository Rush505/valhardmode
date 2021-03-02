using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(CharacterDrop), "GenerateDropList")]
    public static class DropRateOverrides
    {
        private static void Postfix(ref CharacterDrop __instance, ref Character ___m_character)
        {
            if (Configuration.Current.IsEnabled)
            {
                if (___m_character.m_name == "")
                {

                }
            }
        }
    }
}
