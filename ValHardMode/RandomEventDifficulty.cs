using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(RandEventSystem), "Awake")]
    public static class RandomEventDifficulty
    {
        private static void Postfix(ref RandEventSystem __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                foreach (RandomEvent evnt in __instance.m_events)
                {
                    if (evnt.m_name == "surtlings")
                    {
                        // Disable sturtline random event
                        evnt.m_enabled = false;
                    }

                    if (evnt.m_name == "skeletons" || evnt.m_name == "foresttrolls")
                    {
                        // Allow skeletons and trolls event to happen after killing Eikthyr
                        evnt.m_requiredGlobalKeys.Clear();
                    }

                    // Increase duration
                    evnt.m_duration = evnt.m_duration * 2;

                    // Double the possible spawn groups
                    foreach (SpawnSystem.SpawnData spawn in evnt.m_spawn)
                    {
                        spawn.m_groupSizeMax = spawn.m_groupSizeMax * 3;
                        spawn.m_spawnChance = spawn.m_spawnChance * 3;
                    }
                }

                // Increase chance of happening
                __instance.m_eventChance = __instance.m_eventChance * 4;

            }
        }
    }
}
