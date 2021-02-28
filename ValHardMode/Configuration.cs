using BepInEx.Configuration;

namespace ValHardMode
{
    public class Configuration
    {
        public static Configuration Current { get; set; }

        public string Version = "0.0.5";
        public bool IsEnabled { get; set; }

        public ConfigEntry<string> DeleteHotkey { get; set; }

        // Enemies
        public float EnemyLevelUpChanceFactor = 4f;
        public int MaxLevelEnemyDrops = 1;
        public bool TamedDropNormalLoot = true;
        public float EnemyLevelSizeIncreaseFactor = .3f;
        public float NonBossEnemyMaxHealthFactor = 1.5f;
        public float TrollMovementSpeedFactor = 10f;
        public float EikthyrMovementSpeedFactor = 30f;
        public float EikthyrAttackSpeedFactor = 20f;
        public float EikthyrAttackDamageFactor = 2f;
        public float GreydwarfAttackDamageFactor = 2f;
        public float GreydwarfMovementSpeedFactor = 10f;

        // Recipes
        public RecipeOverride[] RecipeOverrides = new RecipeOverride[]
        {
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
                        Name = "$item_trophy_deer",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
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
                Name = "Recipe_ShieldWood",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 8
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
                    }
                }
            },
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
                        Name = "$item_trophy_neck",
                        Amount = 2,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
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
                        Name = "$item_trophy_deer",
                        Amount = 1,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
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
                        Name = "$item_trophy_deer",
                        Amount = 1,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 1,
                        AmountPerLevel = 1,
                        Recover = true
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
                        Name = "$item_trophy_deer",
                        Amount = 1,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 1,
                        AmountPerLevel = 1,
                        Recover = true
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
                        Name = "$item_trophy_deer",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 1,
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
                    }
                }
            }
        };

        // Pieces
        public PieceOverride[] PieceOverrides = new PieceOverride[]
        {
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
                Name = "piece_smelter",
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
                    },
                    new OverrideReq()
                    {
                        Name = "$item_surtlingcore",
                        Amount = 10
                    }
                }
            }
        };


        public class PieceOverride
        {
            public string Name;
            public OverrideReq[] Requirements;
        }

        public class RecipeOverride
        {
            public string Name;
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
        }
    }
}
