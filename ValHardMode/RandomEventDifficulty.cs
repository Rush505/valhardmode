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
                        // Disable sturtlings random event
                        evnt.m_enabled = false;
                    }

                    if (Configuration.Current.RandomEventsToRemoveReqs.Contains(evnt.m_name))
                    {
                        // Clear any boss kill requirements
                        evnt.m_requiredGlobalKeys.Clear();
                    }

                    if (Configuration.Current.RandomEventsToRemoveLimits.Contains(evnt.m_name))
                    {
                        // Clear any no boss kill requirements
                        evnt.m_notRequiredGlobalKeys.Clear();
                    }

                    // Double the possible spawn groups
                    foreach (SpawnSystem.SpawnData spawn in evnt.m_spawn)
                    {
                        spawn.m_maxSpawned = spawn.m_maxSpawned * 3;
                        spawn.m_groupSizeMax = spawn.m_groupSizeMax * 3;
                        spawn.m_spawnChance = spawn.m_spawnChance * 3;
                    }
                }

                // Increase chance of happening
                __instance.m_eventChance = Configuration.Current.RandomEventChance;

                // Decrease minimum time to happen
                __instance.m_eventIntervalMin = Configuration.Current.RandomEventIntervalMin;
            }
        }
    }
}
