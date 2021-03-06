using System.Collections.Generic;

namespace ValHardMode
{
    public class Configuration
    {
        public static Configuration Current { get; set; }

        public string Version = "1.0.2";
        public bool IsEnabled { get; set; }
        public string WorldSuffixEnabler = "VHM";

        public int DataRateOverride = 128;

        // Building
        public float CraftingStationBuildRangeFactor = 2;
        public float MaxStationExtensionDistance = 10;
        public float TreeGrowSpeedFactor = 3;

        // Player
        public float UnarmedBaseDamage = 50;
        public float ComfortRange = 25f;
        public float ToolUseDelay = .25f;

        // Ship
        public float KarveWeightMax = 1000;
        public float LongshipWeightMax = 4000;

        public float ShipWaterImpactDamageFactor = 2.5f;
        public float ShipWaterImpactIntervalFactor = .5f;
        public float ShipUpsideDownDamageFactor = 2.5f;

        public int KarveCargoSlotsWidth = 3;

        // Random Events
        public int RandomEventMaxSpawnedFactor = 2;
        public float RandomEventChance = 33;
        public float RandomEventIntervalMin = 30;
        public List<string> RandomEventsToDisable = new List<string>()
        {
            "surtlings"
        };
        public List<string> RandomEventsToRemoveReqs = new List<string>()
        {
            "skeletons"
        };
        public List<string> RandomEventsToRemoveLimits = new List<string>()
        {
            "skeletons"
        };

        // All Enemies
        // Spawning
        public int EnemySpawnAmountFactor = 2;
        public float EnemyLevelUpChanceFactor = 4;
        public float EnemyLevelSizeIncreaseFactor = .2f;

        // AI
        public bool RemoveEnemyFireAvoid = true;
        public float EnemyAttackMinIntervalFactor = .5f;

        // Attack
        public float EnemyAttackDamageFactor = 1.75f;
        public float EnemyAttackIntervalFactor = .5f;
        public float EnemyAttackSpeedFactor = .5f;

        // Non-bosses
        public float NonBossEnemyMaxHealthFactor = 2.3f;

        // Unique Enemies
        // Troll
        public float TrollMovementSpeedFactor = 2f;

        // Bosses
        public float BossMaxHealthFactor = 1.5f;

        public float EikthyrMovementSpeedFactor = 3f;
        public float EikthyrAttackSpeedFactor = 2f;
        public float EikthyrAttackMinIntervalFactor = .3f;

        public float ElderMovementSpeedFactor = 3f;

        // Enemy drops
        public int MaxLevelEnemyDrops = 2;

        public EnemyDropOverride[] EnemyDropOverrides = new EnemyDropOverride[]
        {
            new EnemyDropOverride()
            {
                Name = "$enemy_greyling",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_resin",
                        Chance = .5f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_greydwarf",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_greydwarf",
                        Chance = .1f
                    },
                    new DropOverride()
                    {
                        ItemName = "$item_resin",
                        Chance = .1f
                    },
                    new DropOverride()
                    {
                        ItemName = "$item_greydwarfeye",
                        Chance = .25f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_greydwarfshaman",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_greydwarfeye",
                        Chance = .25f
                    },
                    new DropOverride()
                    {
                        ItemName = "$item_resin",
                        Chance = .25f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_greydwarfbrute",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_greydwarfeye",
                        Chance = .25f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_wraith",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_wraith",
                        Chance = .1f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_drake",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_hatchling",
                        Chance = .1f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_draugr",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_draugr",
                        Chance = .2f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_boar",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_boar",
                        Chance = .1f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_deathsquito",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_deathsquito",
                        Chance = .1f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_deer",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_deer",
                        Chance = .25f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_goblinbrute",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_goblinbrute",
                        Chance = .1f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_stonegolem",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_sgolem",
                        Chance = .1f
                    }
                }
            }
        };

        // Recipes
        public RecipeOverride[] RecipeOverrides = new RecipeOverride[]
        {
            #region Arrows
            new RecipeOverride()
            {
                Name = "Recipe_ArrowWood",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10,
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowFlint",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10,
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flint",
                        Amount = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowFire",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flint",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3,
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 10,
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowFrost",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 5
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowPoison",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 5
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowObsidian",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowSilver",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowNeedle",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    }
                }
            },
            #endregion

            #region  Weapons

            #region Clubs
            new RecipeOverride()
            {
                Name = "Recipe_Club",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SledgeStagbreaker",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 15
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MaceBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Amount = 5,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_greydwarfbrute",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MaceIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 10,
                        AmountPerLevel = 3,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flint",
                        Amount = 10,
                        AmountPerLevel = 5,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SledgeIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 50,
                        AmountPerLevel = 20
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MaceSilver", // Frostner
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 40,
                        AmountPerLevel = 15
                    },
                    new OverrideReq()
                    {
                        Name = "$item_elderbark",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_ymirremains",
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_freezegland",
                        AmountPerLevel = 2
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MaceNeedle", // Porcupine
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_needle",
                        Amount = 10,
                        AmountPerLevel = 4
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_linenthread",
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_blackmetal",
                        Amount = 10,
                        AmountPerLevel = 4
                    }
                }
            },
            #endregion

            #region  Axes
            new RecipeOverride()
            {
                Name = "Recipe_AxeStone",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_AxeFlint",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_boar",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_AxeBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 4
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Amount = 2,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_Battleaxe",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_elderbark",
                        Amount = 40,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 10,
                        AmountPerLevel = 4,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_AxeIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 12
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 10,
                        AmountPerLevel = 3,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_AxeBlackMetal",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 10,
                        AmountPerLevel = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_blackmetal",
                        Amount = 25
                    },
                    new OverrideReq()
                    {
                        Name = "$item_linenthread",
                        Amount = 15
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 15,
                        AmountPerLevel = 7,
                        Recover = true
                    }
                }
            },
            #endregion

            #region  Pickaxes
            new RecipeOverride()
            {
                Name = "Recipe_PickaxeBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 5,
                        AmountPerLevel = 2
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_PickaxeIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 12
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 5,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 10,
                        AmountPerLevel = 3,
                        Recover = true
                    }
                }
            },
            #endregion

            #region Swords
            new RecipeOverride()
            {
                Name = "Recipe_SwordBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Amount = 5,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 10,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SwordIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 10,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flint",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SwordFire",
                Enabled = true,
                MinStationLevel = 4,
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flametal",
                        Amount = 40,
                        AmountPerLevel = 12
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 15,
                        AmountPerLevel = 4,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_ymirremains",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SwordSilver",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 10,
                        AmountPerLevel = 5,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 20,
                        AmountPerLevel = 10,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_crystal",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SwordBlackmetal",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 10,
                        AmountPerLevel = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_linenthread",
                        Amount = 15
                    },
                    new OverrideReq()
                    {
                        Name = "$item_blackmetal",
                        Amount = 25,
                        AmountPerLevel = 12
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 15,
                        AmountPerLevel = 7,
                        Recover = true
                    }
                }
            },
            #endregion

            #region Knives
            new RecipeOverride()
            {
                Name = "Recipe_KnifeFlint",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 4,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        AmountPerLevel = 1
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_KnifeCopper",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 6,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 2
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_KnifeChitin",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 6,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        AmountPerLevel = 1
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_KnifeBlackmetal",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 8,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_linenthread",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_blackmetal",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 10,
                        AmountPerLevel = 4,
                        Recover = true
                    }
                }
            },
            #endregion

            #region Atgeirs
            new RecipeOverride()
            {
                Name = "Recipe_AtgeirBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Amount = 5,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_AtgeirIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 15,
                        AmountPerLevel = 5,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flint",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_AtgeirBlackmetal",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 15,
                        AmountPerLevel = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_linenthread",
                        Amount = 20
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 10,
                        AmountPerLevel = 4,
                        Recover = true
                    }
                }
            },
            #endregion

            #region Spears
            new RecipeOverride()
            {
                Name = "Recipe_SpearBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 4
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 2,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SpearWolfFang",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_elderbark",
                        Amount = 20,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 10,
                        AmountPerLevel = 4
                    },
                    new OverrideReq()
                    {
                        Name = "$item_crystal",
                        Amount = 2,
                        AmountPerLevel = 1
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SpearChitin",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 20,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            #endregion

            #region Bows
            new RecipeOverride()
            {
                Name = "Recipe_Bow",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10,
                        AmountPerLevel = 6,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_boar",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_BowFineWood",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_deer",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_BowHuntsman",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 20,
                        AmountPerLevel = 8,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_BowDraugrFang",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_elderbark",
                        Amount = 25,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 30,
                        AmountPerLevel = 12
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wolffang",
                        Amount = 4,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_guck",
                        Amount = 15,
                        AmountPerLevel = 5,
                        Recover = true
                    }
                }
            },
            #endregion

            #endregion

            #region Shields
            new RecipeOverride()
            {
                Name = "Recipe_ShieldWood",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ShieldWoodTower",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 25,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 10,
                        AmountPerLevel = 4,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ShieldBronzeBuckler",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 5,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ShieldBanded",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 10,
                        AmountPerLevel = 7,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flint",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ShieldIronTower",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 15,
                        AmountPerLevel = 10,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flint",
                        Amount = 10,
                        AmountPerLevel = 4,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ShieldSilver",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 25
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_crystal",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flint",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ShieldBlackmetal",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 20
                    },
                    new OverrideReq()
                    {
                        Name = "$item_blackmetal",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_chain",
                        Amount = 6,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 10,
                        AmountPerLevel = 4,
                        Recover = true
                    }
                }
            },
            #endregion

            #region Armor
            new RecipeOverride()
            {
                Name = "Recipe_HelmetLeather",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 1
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorLeatherChest",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 1
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorLeatherLegs",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 1
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_CapeDeerHide",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 2,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorTrollLeatherChest",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 10,
                        AmountPerLevel = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorTrollLeatherLegs",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 10,
                        AmountPerLevel = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_CapeTrollHide",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 10,
                        AmountPerLevel = 4
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_HelmetBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorBronzeChest",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorBronzeLegs",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_HelmetIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 35,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorIronChest",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 40,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 4,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorIronLegs",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 40,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 4,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_HelmetDrake",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 35,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wolfpelt",
                        Amount = 4,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_crystal",
                        Amount = 2,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorWolfChest",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 40,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wolfpelt",
                        Amount = 8,
                        AmountPerLevel = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_chain",
                        Amount = 3,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 15,
                        AmountPerLevel = 5,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorWolfLegs",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wolffang",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 40,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wolfpelt",
                        Amount = 8,
                        AmountPerLevel = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_chain",
                        Amount = 3,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 15,
                        AmountPerLevel = 5,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_CapeWolf",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wolfpelt",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 8,
                        AmountPerLevel = 4
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wolffang",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_HelmetPadded",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_linenthread",
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorPaddedCuirass",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_linenthread",
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorPaddedGreaves",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_linenthread",
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_CapeLinen",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_linenthread",
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 1,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_blackmetal",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_CapeLox",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_linenthread",
                        Amount = 4,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_blackmetal",
                        Amount = 1,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            #endregion

            #region Consumables
            new RecipeOverride()
            {
                Name = "Recipe_MeadBaseHealthMinor",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MeadBaseHealthMedium",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 10,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MeadBaseStaminaMinor",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MeadBaseStaminaMedium",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 10,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MeadBaseTasty",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_QueensJam",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_CarrotSoup",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_mushroomcommon",
                        Amount = 2
                    }
                }
            }
            #endregion
        };

        // Pieces
        public PieceOverride[] PieceOverrides = new PieceOverride[]
        {
            new PieceOverride()
            {
                Name = "Maypole",
                Enabled = true
            },
            new PieceOverride()
            {
                Name = "$piece_bonfire",
                GroundOnly = false,
                NotOnWood = false
            },
            new PieceOverride()
            {
                Name = "$piece_raise",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 1
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_firepit",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_groundtorchwood",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 10
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_workbench",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 20
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 3,
                        AmountPerLevel = 5,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 2,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_cookingstation",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 2,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$ship_raft",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 30
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_cauldron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_tin",
                        Amount = 15,

                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_forge",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 25
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_copper",
                        Amount = 10
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_smelter",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 40
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_charcoalkiln",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 50
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_blastfurnace",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 50
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_stonecutter",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 15
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 20
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_artisanstation",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 20
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 10,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_windmill",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 50
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 10,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_spinningwheel",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 30
                    },
                    new OverrideReq()
                    {
                        Name = "$item_chitin",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            }
        };


        public class PieceOverride
        {
            public string Name;

            private bool m_enabled;
            public bool EnabledIsSet = false;
            public bool Enabled
            {
                get
                {
                    return m_enabled;
                }
                set
                {
                    m_enabled = value;
                    EnabledIsSet = true;
                }
            }

            private bool m_groundOnly;
            public bool GroundOnlyIsSet = false;
            public bool GroundOnly
            {
                get
                {
                    return m_groundOnly;
                }
                set
                {
                    m_groundOnly = value;
                    GroundOnlyIsSet = true;
                }
            }

            private bool m_notOnWood;
            public bool NotOnWoodIsSet = false;
            public bool NotOnWood
            {
                get
                {
                    return m_notOnWood;
                }
                set
                {
                    m_notOnWood = value;
                    NotOnWoodIsSet = true;
                }
            }

            public OverrideReq[] Requirements;
        }

        public class RecipeOverride
        {
            public string Name;

            private bool m_enabled;
            public bool EnabledIsSet = false;
            public bool Enabled
            {
                get
                {
                    return m_enabled;
                }
                set
                {
                    m_enabled = value;
                    EnabledIsSet = true;
                }
            }

            private int m_minStationLevel;
            public bool MinStationLevelIsSet = false;
            public int MinStationLevel
            {
                get
                {
                    return m_minStationLevel;
                }
                set
                {
                    m_minStationLevel = value;
                    MinStationLevelIsSet = true;
                }
            }

            public OverrideReq[] Requirements;
        }

        public class OverrideReq
        {
            public string Name;
            private int m_amount;
            public bool AmountIsSet = false;
            public int Amount
            {
                get
                {
                    return m_amount;
                }
                set
                {
                    m_amount = value;
                    AmountIsSet = true;
                }
            }

            private int m_amountPerLevel;
            public bool AmountPerLevelIsSet = false;
            public int AmountPerLevel
            {
                get
                {
                    return m_amountPerLevel;
                }
                set
                {
                    m_amountPerLevel = value;
                    AmountPerLevelIsSet = true;
                }
            }
            private bool m_recover;
            public bool RecoverIsSet = false;
            public bool Recover
            {
                get
                {
                    return m_recover;
                }
                set
                {
                    m_recover = value;
                    RecoverIsSet = true;
                }
            }
            public bool Remove = false;
        }

        public class EnemyDropOverride
        {
            public string Name;
            public DropOverride[] Drops;
        }

        public class DropOverride
        {
            public string ItemName;
            private int m_amountMin;
            public bool AmountMinIsSet = false;
            public int AmountMin
            {
                get
                {
                    return m_amountMin;
                }
                set
                {
                    m_amountMin = value;
                    AmountMinIsSet = true;
                }
            }
            private int m_amountMax;
            public bool AmountMaxIsSet = false;
            public int AmountMax
            {
                get
                {
                    return m_amountMax;
                }
                set
                {
                    m_amountMax = value;
                    AmountMaxIsSet = true;
                }
            }
            private float m_chance;
            public bool ChanceIsSet = false;
            public float Chance
            {
                get
                {
                    return m_chance;
                }
                set
                {
                    m_chance = value;
                    ChanceIsSet = true;
                }
            }
            private bool m_onePerPlayer;
            public bool OnePerPlayerIsSet = false;
            public bool OnePerPlayer
            {
                get
                {
                    return m_onePerPlayer;
                }
                set
                {
                    m_onePerPlayer = value;
                    OnePerPlayerIsSet = true;
                }
            }
            private bool m_levelMultiplier;
            public bool LevelMultiplierIsSet = false;
            public bool LevelMultiplier
            {
                get
                {
                    return m_levelMultiplier;
                }
                set
                {
                    m_levelMultiplier = value;
                    LevelMultiplierIsSet = true;
                }
            }
            public bool Remove = false;
        }
    }
}
