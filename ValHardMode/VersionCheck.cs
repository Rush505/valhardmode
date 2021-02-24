using HarmonyLib;
using System;
using System.Collections.Generic;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ZNet), "Awake")]
    public static class DefaultModStatus
    {
        private static void Postfix(ref ZNet __instance)
        {
            // Always enable mod on server and disable on client by default
            Configuration.Current.IsEnabled = __instance.IsServer();

            // Store ZNet instance for use by handlers
            RpcHandlers._zNetInstance = __instance;
        }
    }

    [HarmonyPatch(typeof(ZNet), "OnNewConnection")]
    public static class RegisterAndCheckVersion
    {
        private static void Prefix(ZNetPeer peer, ref ZNet __instance)
        {
            // Register version check call
            ZLog.LogWarning("ValHardMode - Registering version RPC handler");
            peer.m_rpc.Register<ZPackage>("ValHardMode_Version", new Action<ZRpc, ZPackage>(RpcHandlers.RPC_ValHardMode_Version));

            // Make calls to check versions
            ZLog.LogWarning("ValHardMode - Invoking version check");
            ZPackage zpackage = new ZPackage();
            zpackage.Write(ValHardMode.version);
            peer.m_rpc.Invoke("ValHardMode_Version", (object)zpackage);
        }
    }

    [HarmonyPatch(typeof(ZNet), "RPC_PeerInfo")]
    public static class VerifyClient
    {
        private static bool Prefix(ZRpc rpc, ZPackage pkg, ref ZNet __instance)
        {
            if (__instance.IsServer() && !RpcHandlers._validatedPeers.Contains(rpc))
            {
                // Disconnect peer if they didn't send mod version at all
                ZLog.LogWarning("ValHardMode - Peer never sent version, disconnecting");
                rpc.Invoke("Error", (object)3);
                return false; // Prevent calling underlying method
            }

            return true;
        }
    }

    [HarmonyPatch(typeof(ZNet), "Disconnect")]
    public static class RemoveDisconnectedPeerFromVerified
    {
        private static void Prefix(ZNetPeer peer, ref ZNet __instance)
        {
            if (__instance.IsServer())
            {
                // Remove peer from validated list
                ZLog.LogWarning("ValHardMode - Peer disconnected, removing from validated list");
                RpcHandlers._validatedPeers.Remove(peer.m_rpc);
            }
        }
    }

    public static class RpcHandlers
    {
        public static ZNet _zNetInstance;
        public static List<ZRpc> _validatedPeers = new List<ZRpc>();

        public static void RPC_ValHardMode_Version(ZRpc rpc, ZPackage pkg)
        {
            var version = pkg.ReadString();
            ZLog.LogWarning("ValHardMode - Version check, theirs: " + version + ",  mine: " + ValHardMode.version);
            if (version != ValHardMode.version)
            {
                
                if (_zNetInstance.IsServer())
                {
                    // Different versions - force disconnect client from server
                    ZLog.LogWarning("ValHardMode - Peer has incompatible version, disconnecting");
                    rpc.Invoke("Error", (object)3);
                }
            }
            else
            {
                if (!_zNetInstance.IsServer())
                {
                    // Enable mod on client if versions match
                    ZLog.LogWarning("ValHardMode - Recieved same version from server, enabling!");
                    Configuration.Current.IsEnabled = true;
                }
                else
                {
                    // Add client to validated list
                    ZLog.LogWarning("ValHardMode - Adding peer to validated list");
                    _validatedPeers.Add(rpc);
                }
            }
        }
    }
}
