import os

# Chemin racine du dossier
root_path = os.path.join("Content", "Items", "Accessories")

# --- ETAPE 1 : NETTOYAGE COMPLET ET RADICAL ---
print("--- NETTOYAGE INTÉGRAL DU DOSSIER ACCESSORIES ---")
if os.path.exists(root_path):
    for root, dirs, files in os.walk(root_path):
        for file in files:
            if file.endswith(".cs"):
                file_to_remove = os.path.join(root, file)
                try:
                    os.remove(file_to_remove)
                except Exception as e:
                    print(f"Impossible de supprimer {file_to_remove} : {e}")
    print("[Nettoyage] Tous les anciens fichiers .cs ont été supprimés.")

# --- ETAPE 2 : LE MANIFESTE STRICT DES 222 ÉLÉMENTS ---
items_manifest = {
    "Common": [ # (36) White
        "ArmorPiercingRounds", "BackupMagazine", "BisonSteak", "Blanket", "BolsteringLantern", 
        "BundleOfFireworks", "BustlingFungus", "CautiousSlug", "Crowbar", "DelicateWatch", 
        "EnergyDrink", "FocusCrystal", "Gasoline", "KnockbackFin", "LensMakersGlasses", 
        "Medkit", "Mocha", "MonsterTooth", "OddlyShapedOpal", "PaulsGoatHoof", 
        "PersonalShieldGenerator", "PowerElixir", "RepulsionArmorPlate", "RollOfPennies", 
        "RustedKey", "SoldiersSyringe", "StickyBomb", "StunGrenade", "TopazBrooch", 
        "TougherTimes", "TriTipDagger", "Warbanner", "WarpedEcho", "WhiteScrap",
        "AntlerShield", "AuraFlare"
    ],
    
    "Uncommon": [ # (42) Green
        "AtGMissileMk1", "Bandolier", "BerzerkersPauldron", "ChanceDoll", "Chronobauble", 
        "DeathMark", "FuelCell", "GhorsTome", "GreenScrap", "HarvestersScythe", 
        "HopooFeather", "HuntersHarpoon", "IgnitionTank", "Infusion", "KjarosBand", 
        "LeechingSeed", "LeptonDaisy", "LuminousShot", "OldGuillotine", "OldWarStealthkit", 
        "PredatoryInstincts", "Razorwire", "RedWhip", "RegeneratingScrap", "RoseBuckler", 
        "RunaldsBand", "ShippingRequestForm", "Shuriken", "SquidPolyp", "Ukulele", 
        "UnstableTransmitter", "WarHorn", "WaxQuail", "WillOTheWisp", "ChronicExaggeration", 
        "SaleStar", "PrayerBeads", "SeedOfWealth", "SymbioticScorpion", "SorghumScrap", 
        "SporeSac", "SlowOnHit"
    ],
    
    "Legendary": [ # (36) Red
        "Aegis", "AlienHead", "BensRaincoat", "BottledChaos", "Brainstalks", 
        "BrilliantBehemoth", "CeremonialDagger", "DefensiveMicrobots", "DiosBestFriend", 
        "FiftySevenLeafClover", "FrostRelic", "GrowthNectar", "H3AD5Tv2", 
        "HappiestMask", "HardlightAfterburner", "InterstellarDeskPlant", "LaserScope", 
        "NkuhanasOpinion", "PocketICBM", "RedScrap", "ResonanceDisc", "RunicLens", 
        "SentientMeatHook", "ShatteringJustice", "SonorousWhispers", "SoulboundCatalyst", 
        "SpareDroneParts", "UnstableTeslaCoil", "WakeOfVultures", "HeadHunter", 
        "ImmuneToDebuffs", "KillElitePowerUp", "LightningStrikeOnHit", "MageAttunement", 
        "PlanetKill", "TreasureHunter"
    ],
    
    "Boss": [ # (22) Yellow
        "ArtifactKey", "BoundlessPotential", "ChargedPerforator", "ColossalKnurl", 
        "DefenseNucleus", "EmpathyCores", "GenesisLoop", "HalcyonSeed", 
        "IrradiantPearl", "LittleDisciple", "MiredUrn", "MoltenPerforator", 
        "Pearl", "Planula", "QueensGland", "Shatterspleen", "TitanicKnurl", "YellowScrap",
        "GravekeeperHook", "KnockbackFinClassic", "AlloyWorshipHelper", "TitanGoldDefDef"
    ],
    
    "Lunar": [ # (20) Blue
        "BeadsOfFealty", "CorpseBloom", "DefiantGouge", "EgoCentrism", "EssenceOfHeresy", 
        "EulogyZero", "FocusedConvergence", "GestureOfTheDrowned", "HooksOfHeresy", "LightFluxPauldron", 
        "MercurialRachis", "Purity", "ShapedGlass", "StoneFluxPauldron", "StridesOfHeresy", 
        "VisionsOfHeresy", "LunarTrinket", "TonicAffliction", "CutHp", "CancelCooldowns"
    ],
    
    "Void": [ # (14) Purple
        "BenthicBloom", "EncrustedKey", "LostSeersLenses", "LysateCell", "Needletick", 
        "NewlyHatchedZoea", "PlasmaShrimp", "PluripotentLarva", "Polylute", "SaferSpaces", 
        "SingularityBand", "Tentabauble", "VoidsentFlame", "WeepingFungus"
    ],
    
    "Equipment": [ # (44) Orange
        "BlastShower", "DisposableMissileLauncher", "EccentricVase", "ExecutiveCard", "ForeignFruit", 
        "ForgiveMePlease", "FuelArray", "GnarledWoodsprite", "GooboJr", "GoragsOpus", 
        "JadeElephant", "MilkyChrysalis", "MolotovSixPack", "OcularHUD", "PreonAccumulator", 
        "PrimordialCube", "RadarScanner", "Recycler", "RemoteCaffeinator", "RoyalCapacitor", 
        "Sawmerang", "SuperMassiveLeech", "TheBackup", "TheCrowdfunder", "TrophyHuntersTricorn", 
        "VolcanicEgg", "EffigyOfGrief", "GlowingMeteorite", "HelfireTincture", "SpinelTonic", 
        "Enigma", "GoldGat", "Lightning", "Nuke", "Scanner", "IfritsDistinction", 
        "HerBitingEmbrace", "SilenceBetweenTwoStrikes", "HisReassurance", "NkuhanasRetort", "SpectralCirclet", 
        "SharedDesign", "TrickerTreat", "QuestVolcanicPlume"
    ],
    
    "Untiered": [ # (8) Suppléments demandés
        "ExtraLifeConsumed", "DioEngineHelper", "AdaptiveArmorHelper", "FalseSonBossPassive", 
        "HereticWeaponHelper", "GoldOrbHelper", "CaptainDefenseMatrix", "ArtifactWorldKey"
    ]
}

# --- ETAPE 3 : GENERATION ---
print("\n--- CRÉATION DE LA STRUCTURE ACCESSOIRES ---")
total_created = 0

for category, items in items_manifest.items():
    category_dir = os.path.join(root_path, category)
    os.makedirs(category_dir, exist_ok=True)
    
    for item in items:
        file_path = os.path.join(category_dir, f"{item}.cs")
        content = f"""// TODO: Implement item logic
namespace RiskOfRain2.Content.Items.Accessories.{category}
{{

}}"""
        with open(file_path, "w", encoding="utf-8") as f:
            f.write(content)
        total_created += 1

print(f"\n[Terminé] Reconstitution stricte effectuée.")
print(f"[Statistiques] {total_created} fichiers .cs générés au total.")