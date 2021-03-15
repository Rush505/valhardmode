//using HarmonyLib;
//using System.Collections.Generic;
//using UnityEngine;

//namespace ValHardMode
//{
//    [HarmonyPatch]
//    public static class MeteorRandomEvent
//    {
//        private static float m_timeSinceLastMeteor = 0;
//        private static float m_meteorMinTimeMinutes = .2f;
//        private static float m_meteorChance = 100;

//        [HarmonyPostfix]
//        [HarmonyPatch(typeof(RandEventSystem), "FixedUpdate")]
//        private static void PostFixedUpdate()
//        {
//            if (!ZNet.instance.IsServer())
//                return;

//            float fixedDeltaTime = Time.fixedDeltaTime;
//            m_timeSinceLastMeteor += fixedDeltaTime;

//            if (m_timeSinceLastMeteor > m_meteorMinTimeMinutes * 60.0)
//            {
//                ZLog.Log("ValHardMode - Rolling for meteor chance");
//                m_timeSinceLastMeteor = 0.0f;

//                if (UnityEngine.Random.Range(0.0f, 100f) <= m_meteorChance)
//                {
//                    List<ZDO> allCharacterZdos = ZNet.instance.GetAllCharacterZDOS();
//                    List<Vector3> characterPositions = new List<Vector3>();

//                    foreach (ZDO character in allCharacterZdos)
//                    {
//                        if (character.GetPosition().y <= 3000.0)
//                            characterPositions.Add(character.GetPosition());
//                    }

//                    if (characterPositions.Count > 0)
//                    {
//                        ZLog.Log("ValHardMode - Meteor strike incoming");
//                        var targetPos = characterPositions[UnityEngine.Random.Range(0, characterPositions.Count)];

//                        int xSign = Random.Range(0, 2) * 2 - 1;
//                        int zSign = Random.Range(0, 2) * 2 - 1;

//                        var spawnPos = new Vector3(targetPos.x + 55 * xSign, targetPos.y + 150, targetPos.z + 55 * zSign);
//                        var velocity = new Vector3(-30 * xSign, -80, -30 * zSign);

//                        ZLog.Log("ValHardMode - Sending meteor strike RPC call");
//                        MeteorRandomEvent.SpawnMeteor(spawnPos, velocity);
//                    }
//                }
//            }
//        }

//        public static void SpawnMeteor(Vector3 spawnPoint, Vector3 velocity)
//        {
//            var meteorPrefab = ZNetScene.instance.GetPrefab("projectile_meteor");
//            if (meteorPrefab == null)
//            {
//                ZLog.LogWarning("ValHardMode - Unable to get meteor prefabs");
//                return;
//            }

//            HitData hit = new HitData()
//            {
//                m_damage = new HitData.DamageTypes()
//                {
//                    m_blunt = 1000,
//                    m_pickaxe = 1000,
//                    m_chop = 1000,
//                    m_fire = 500
//                },
//                m_pushForce = 1000
//            };

//            Projectile projectile = meteorPrefab.GetComponent<Projectile>();
//            projectile.name = "event-meteor";
//            projectile.m_ttl = -1;
//            projectile.Setup(null, velocity, 20f, hit, null);

//            // Spawn meteor
//            ZLog.Log("ValHardMode - Spawning Meteor");
            
//        }

//        [HarmonyPostfix]
//        [HarmonyPatch(typeof(Console), "InputText")]
//        private static void ConsoleSpawnMeteor(ref Console __instance)
//        {
//            var inputTxt = __instance.m_input.text;

//            if (__instance.IsCheatsEnabled() && inputTxt.StartsWith("meteor "))
//            {
//                string[] txtArr = inputTxt.Split(' ');

//                int spawnX = 0;
//                int spawnY = 0;
//                int spawnZ = 0;
//                int velocityX = 0;
//                int velocityY = 0;
//                int velocityZ = 0;

//                int.TryParse(txtArr[1], out spawnX);
//                int.TryParse(txtArr[2], out spawnY);
//                int.TryParse(txtArr[3], out spawnZ);
//                int.TryParse(txtArr[4], out velocityX);
//                int.TryParse(txtArr[5], out velocityY);
//                int.TryParse(txtArr[6], out velocityZ);

//                var playerPos = Player.m_localPlayer.transform.position;
//                var spawnPoint = new Vector3(playerPos.x + spawnX, playerPos.y + spawnY, playerPos.z + spawnZ);
//                var velocity = new Vector3(velocityX, velocityY, velocityZ);

//                MeteorRandomEvent.SpawnMeteor(spawnPoint, velocity);
//            }
//        }
//    }


    //[HarmonyPatch(typeof(Projectile))]
    //public static class SpawnFlametalMineOnMeteorHit
    //{
    //    [HarmonyPrefix]
    //    [HarmonyPatch("OnHit")]
    //    private static void SpawnOnHitPrefix(ref Projectile __instance, Collider collider, Vector3 hitPoint, bool water)
    //    {
    //        if (__instance.name == "event-meteor" && !water)
    //        {
    //            ZLog.Log("ValHardMode - Spawning meteorite mine");

    //            if (!Location.IsInsideNoBuildLocation(hitPoint))
    //            {
    //                ItemDrop weapon = ObjectDBWrapper.GetItem("$item_pickaxe_iron");
    //                if (weapon != null)
    //                {
    //                    GameObject spawnOnHitPrefab = weapon.m_itemData.m_shared.m_spawnOnHitTerrain;
    //                    if (spawnOnHitPrefab != null)
    //                    {
    //                        TerrainModifier.SetTriggerOnPlaced(true);
    //                        GameObject go = UnityEngine.Object.Instantiate<GameObject>(spawnOnHitPrefab, hitPoint, Quaternion.identity);
    //                        TerrainModifier.SetTriggerOnPlaced(false);
    //                        go.GetComponent<IProjectile>()?.Setup(null, Vector3.zero, -1f, null, weapon.m_itemData);
    //                    }
    //                    else
    //                    {
    //                        ZLog.LogWarning("ValHardMode - No spawn on hit prefab found");
    //                    }
    //                }
    //                else
    //                {
    //                    ZLog.LogWarning("ValHardMode - Error loading pickaxe prefab for meteor terrain mod");
    //                }
    //            }

    //            var minePrefab = ZNetScene.instance.GetPrefab("MineRock_Meteorite");
    //            var spawnPoint = new Vector3(hitPoint.x, hitPoint.y - 3, hitPoint.z);
    //            UnityEngine.Object.Instantiate<GameObject>(minePrefab, spawnPoint, Quaternion.identity);

    //            SnapToGround.SnappAll();
    //        }
    //    }
    //}
//}