using HarmonyLib;
using Steamworks;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ZSteamMatchmaking), "RegisterServer")]
    public static class RegisterServerPatch
    {
        private static void Postfix(ZSteamMatchmaking __instance)
        {
            // Update Steam server info
            if (ZNet.instance.IsDedicated())
            {
                SteamGameServer.SetMaxPlayerCount(ZNet.instance.m_serverPlayerLimit);
                SteamGameServer.SetGameDescription("Valheim");
                SteamGameServer.SetMapName(ZNet.instance.GetWorldName());
            }
        }
    }
}