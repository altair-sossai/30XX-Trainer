using System.ComponentModel;

namespace _30XX_Trainer.Enums
{
    public enum Item
    {
        [Description("Small Health")]
        SmallHealth = 1,

        [Description("Large Health")]
        LargeHealth = 2,

        [Description("Small Energy")]
        SmallEnergy = 3,

        [Description("Large Energy")]
        LargeEnergy = 4,

        [Description("Small Nuts")]
        SmallNuts = 5,

        [Description("Large Nuts")]
        LargeNuts = 6,

        [Description("Memoria")]
        Memoria = 7,

        [Description("Shiny Token")]
        ShinyToken = 8,

        [Description("N-Buster")]
        NBuster = 14,

        [Description("Star Beam")]
        StarBeam = 15,

        [Description("Forkalator")]
        Forkalator = 16,

        [Description("Wave Beam")]
        WaveBeam = 17,

        [Description("Scatterblast")]
        Scatterblast = 18,

        [Description("Arc Beam")]
        ArcBeam = 19,

        [Description("Seeker Beam PH")]
        SeekerBeamPh = 20,

        [Description("Frost Beam")]
        FrostBeam = 21,

        [Description("Overcharge Beam PH")]
        OverchargeBeamPh = 22,

        [Description("Retrobeam")]
        Retrobeam = 23,

        [Description("Vertibeam")]
        Vertibeam = 24,

        [Description("Slow Beam PH")]
        SlowBeamPh = 25,

        [Description("Toy Beam")]
        ToyBeam = 26,

        [Description("A-Saber")]
        ASaber = 30,

        [Description("Rippling Axe")]
        RipplingAxe = 32,

        [Description("Laurent")]
        Laurent = 33,

        [Description("Spinning Glaive")]
        SpinningGlaive = 34,

        [Description("Tonbokiri")]
        Tonbokiri = 35,

        [Description("Lucavi")]
        Lucavi = 36,

        [Description("Lara")]
        Lara = 37,

        [Description("Grandmaster")]
        Grandmaster = 38,

        [Description("Thanatos")]
        Thanatos = 39,

        [Description("Edgewall")]
        Edgewall = 40,

        [Description("Dawnbind")]
        Dawnbind = 41,

        [Description("Unstoppable Force")]
        UnstoppableForce = 49,

        [Description("Volt Edge")]
        VoltEdge = 50,

        [Description("Vega")]
        Vega = 51,

        [Description("Peacebringer")]
        Peacebringer = 52,

        [Description("Gemini")]
        Gemini = 53,

        [Description("Rapture")]
        Rapture = 54,

        [Description("V-Shooter")]
        VShooter = 65,

        [Description("Plasma Beam")]
        PlasmaBeam = 106,

        [Description("Sage Beam")]
        SageBeam = 107,

        [Description("Wall Beam")]
        WallBeam = 108,

        [Description("Chonk Beam")]
        ChonkBeam = 109,

        [Description("Retrofork")]
        Retrofork = 110,

        [Description("Bouncy Beam")]
        BouncyBeam = 111,

        [Description("Verity Beam")]
        VerityBeam = 112,

        [Description("Spiral Beam")]
        SpiralBeam = 113,

        [Description("Aim Beam")]
        AimBeam = 114,

        [Description("Rocket Beam")]
        RocketBeam = 115,

        [Description("Sniper Beam")]
        SniperBeam = 116,

        [Description("??? Beam")]
        Beam = 117,

        [Description("Juice Beam")]
        JuiceBeam = 118,

        [Description("Chaos Beam")]
        ChaosBeam = 119,

        [Description("Vera")]
        Vera = 150,

        [Description("Zen Mortar")]
        ZenMortar = 151,

        [Description("Boomerang Blade")]
        BoomerangBlade = 152,

        [Description("Dixie Twist")]
        DixieTwist = 153,

        [Description("Shadespur")]
        Shadespur = 154,

        [Description("Crushing Void")]
        CrushingVoid = 156,

        [Description("Transposer")]
        Transposer = 157,

        [Description("Flameshield")]
        Flameshield = 158,

        [Description("Splinterfrost")]
        Splinterfrost = 159,

        [Description("Negation Pulse")]
        NegationPulse = 160,

        [Description("Wildfire")]
        Wildfire = 161,

        [Description("Blastjump")]
        Blastjump = 162,

        [Description("Seeking Striker")]
        SeekingStriker = 163,

        [Description("Protorifle")]
        Protorifle = 165,

        [Description("Transmutation")]
        Transmutation = 169,

        [Description("World Igniter")]
        WorldIgniter = 170,

        [Description("Rending Whirl")]
        RendingWhirl = 176,

        [Description("Crystal Wave")]
        CrystalWave = 177,

        [Description("Aiming Gear")]
        AimingGear = 178,

        [Description("Jagged Bolt")]
        JaggedBolt = 179,

        [Description("Autodrone")]
        Autodrone = 180,

        [Description("Unleash Blade")]
        UnleashBlade = 183,

        [Description("Zen Ascent")]
        ZenAscent = 184,

        [Description("Echo Shell")]
        EchoShell = 185,

        [Description("Dolomite Link")]
        DolomiteLink = 186,

        [Description("Raijin Call")]
        RaijinCall = 187,

        [Description("Osafune")]
        Osafune = 188,

        [Description("Void Double")]
        VoidDouble = 189,

        [Description("Ryuusei")]
        Ryuusei = 190,

        [Description("Leviathan")]
        Leviathan = 191,

        [Description("The cooler Crushing Void")]
        ThecoolerCrushingVoid = 196,

        [Description("Sealing Record Key")]
        SealingRecordKey = 333,

        [Description("Essence of a Sealed Hero")]
        EssenceofaSealedHero = 334,

        [Description("Imbued Chronovane")]
        ImbuedChronovane = 348,

        [Description("Coalesced Entropy")]
        CoalescedEntropy = 362,

        [Description("Multiversal Map")]
        MultiversalMap = 382,

        [Description("Blueprint: Reversal Device")]
        BlueprintReversalDevice = 383,

        [Description("Memento of Harmony")]
        MementoofHarmony = 384,

        [Description("Memento of Devotion")]
        MementoofDevotion = 385,

        [Description("Causation Invalidator")]
        CausationInvalidator = 386,

        [Description("Cathedral Coordinate")]
        CathedralCoordinate = 387,

        [Description("Compressed Chronopulse")]
        CompressedChronopulse = 388,

        [Description("Plumber Hat")]
        PlumberHat = 400,

        [Description("Strongarm Band")]
        StrongarmBand = 401,

        [Description("Speed Juicer")]
        SpeedJuicer = 402,

        [Description("Power Enhancer")]
        PowerEnhancer = 404,

        [Description("Heart Container")]
        HeartContainer = 406,

        [Description("Lander's Essence")]
        LandersEssence = 407,

        [Description("Potato Battery")]
        PotatoBattery = 408,

        [Description("Cerebral Nourishment Meal")]
        CerebralNourishmentMeal = 409,

        [Description("Zephyr")]
        Zephyr = 410,

        [Description("Forcemetal Shell")]
        ForcemetalShell = 413,

        [Description("XCALBER")]
        Xcalber = 414,

        [Description("Glass Cannon")]
        GlassCannon = 415,

        [Description("Vitality Scavenger")]
        VitalityScavenger = 418,

        [Description("Energy Scavenger")]
        EnergyScavenger = 419,

        [Description("Scrapmetal Scavenger")]
        ScrapmetalScavenger = 420,

        [Description("Seven Leaf Clover")]
        SevenLeafClover = 421,

        [Description("Spillover Matrix")]
        SpilloverMatrix = 422,

        [Description("Health Nut")]
        HealthNut = 423,

        [Description("Charged Nuts")]
        ChargedNuts = 424,

        [Description("Nut Replicator")]
        NutReplicator = 428,

        [Description("Orbital Barrier")]
        OrbitalBarrier = 429,

        [Description("Murderdrone")]
        Murderdrone = 430,

        [Description("Renewal Pod")]
        RenewalPod = 431,

        [Description("Shinier Token")]
        ShinierToken = 432,

        [Description("Nutstack")]
        Nutstack = 433,

        [Description("Re-Flapp")]
        ReFlapp = 434,

        [Description("Tiny Flamespewer")]
        TinyFlamespewer = 435,

        [Description("Gapminder")]
        Gapminder = 436,

        [Description("Thorned Revenger")]
        ThornedRevenger = 437,

        [Description("Reboot")]
        Reboot = 438,

        [Description("Vendsmasher")]
        Vendsmasher = 439,

        [Description("Nutsaving Stringwire")]
        NutsavingStringwire = 440,

        [Description("Armor Nut")]
        ArmorNut = 441,

        [Description("Regenerative Plating")]
        RegenerativePlating = 442,

        [Description("Enerative Plating")]
        EnerativePlating = 443,

        [Description("Armorative Plating")]
        ArmorativePlating = 444,

        [Description("Emergency Beacon")]
        EmergencyBeacon = 445,

        [Description("Thrift Actuator")]
        ThriftActuator = 446,

        [Description("Crisis Overdrive")]
        CrisisOverdrive = 447,

        [Description("Crisis Timestopper")]
        CrisisTimestopper = 448,

        [Description("System Restore")]
        SystemRestore = 449,

        [Description("Armor Spreader")]
        ArmorSpreader = 450,

        [Description("Choicebooster")]
        Choicebooster = 451,

        [Description("Armor Bloom")]
        ArmorBloom = 452,

        [Description("Meganut")]
        Meganut = 453,

        [Description("Pure Flame")]
        PureFlame = 454,

        [Description("Forgotten Memento")]
        ForgottenMemento = 455,

        [Description("Bracer of Battle")]
        BracerofBattle = 456,

        [Description("Mobility Realizer")]
        MobilityRealizer = 457,

        [Description("Life Extender")]
        LifeExtender = 458,

        [Description("Megaheart")]
        Megaheart = 459,

        [Description("Vibroreserve")]
        Vibroreserve = 460,

        [Description("Reclaimed Spark")]
        ReclaimedSpark = 461,

        [Description("Armor Scavenger")]
        ArmorScavenger = 462,

        [Description("Entropy Lock")]
        EntropyLock = 463,

        [Description("Striking Feather")]
        StrikingFeather = 464,

        [Description("Thunderous Boon")]
        ThunderousBoon = 465,

        [Description("Band of Might")]
        BandofMight = 466,

        [Description("Mistimed Protector")]
        MistimedProtector = 467,

        [Description("The Volunteer")]
        TheVolunteer = 468,

        [Description("Thrillseeker")]
        Thrillseeker = 469,

        [Description("Quantum Spook")]
        QuantumSpook = 470,

        [Description("Hoarder's Might")]
        HoardersMight = 471,

        [Description("Contractor Plus")]
        ContractorPlus = 472,

        [Description("Contractor Omega")]
        ContractorOmega = 473,

        [Description("Mixmatch Mastery")]
        MixmatchMastery = 474,

        [Description("Charging Magnet")]
        ChargingMagnet = 475,

        [Description("World Slug")]
        WorldSlug = 476,

        [Description("Leafmetal Plating")]
        LeafmetalPlating = 477,

        [Description("Zookeeper's Sigil")]
        ZookeepersSigil = 478,

        [Description("Nutspewer")]
        Nutspewer = 479,

        [Description("Static Clicklets")]
        StaticClicklets = 480,

        [Description("Fortune Stabilizer")]
        FortuneStabilizer = 481,

        [Description("Spicy Incense")]
        SpicyIncense = 482,

        [Description("Patchwork Connector")]
        PatchworkConnector = 483,

        [Description("Vitaboost")]
        Vitaboost = 484,

        [Description("Thorned Hull")]
        ThornedHull = 485,

        [Description("Juiced Reserves")]
        JuicedReserves = 486,

        [Description("Kinetic Converter")]
        KineticConverter = 487,

        [Description("Boltdash")]
        Boltdash = 488,

        [Description("Reflex Rapidifier")]
        ReflexRapidifier = 489,

        [Description("Utilifier")]
        Utilifier = 490,

        [Description("Vibrofocus")]
        Vibrofocus = 491,

        [Description("Leafpetal")]
        Leafpetal = 492,

        [Description("Splintering Twinifier")]
        SplinteringTwinifier = 493,

        [Description("Zookeeper's Zeal")]
        ZookeepersZeal = 494,

        [Description("Crisis Lifebank")]
        CrisisLifebank = 495,

        [Description("Deconstructor's Might")]
        DeconstructorsMight = 496,

        [Description("Armorall")]
        Armorall = 497,

        [Description("Unflappable")]
        Unflappable = 498,

        [Description("Intensifier")]
        Intensifier = 499,

        [Description("Force Resonator")]
        ForceResonator = 500,

        [Description("Case Resonator")]
        CaseResonator = 501,

        [Description("Cranial Resonator")]
        CranialResonator = 502,

        [Description("Kinetic Resonator")]
        KineticResonator = 503,

        [Description("Core Extender")]
        CoreExtender = 504,

        [Description("Core Expander")]
        CoreExpander = 505,

        [Description("Core Bulkener")]
        CoreBulkener = 506,

        [Description("Core Emboldener")]
        CoreEmboldener = 507,

        [Description("Core Luddite")]
        CoreLuddite = 508,

        [Description("Field Integrator")]
        FieldIntegrator = 509,

        [Description("Mobility Enabler")]
        MobilityEnabler = 510,

        [Description("Utility Enabler")]
        UtilityEnabler = 511,

        [Description("Resilience Enabler")]
        ResilienceEnabler = 512,

        [Description("Force Enabler")]
        ForceEnabler = 513,

        [Description("Health Coronator")]
        HealthCoronator = 514,

        [Description("Core Widener")]
        CoreWidener = 515,

        [Description("Core Overloader")]
        CoreOverloader = 516,

        [Description("Core-Hull Multiplexer")]
        CoreHullMultiplexer = 517,

        [Description("Core-Vibro Multiplexer")]
        CoreVibroMultiplexer = 518,

        [Description("Core-Force Multiplexer")]
        CoreForceMultiplexer = 519,

        [Description("Core-Power Multiplexer")]
        CorePowerMultiplexer = 520,

        [Description("Frail Glory")]
        FrailGlory = 521,

        [Description("Shopaholic")]
        Shopaholic = 522,

        [Description("Advanced Repair")]
        AdvancedRepair = 523,

        [Description("Might Harvester")]
        MightHarvester = 524,

        [Description("Power Harvester")]
        PowerHarvester = 525,

        [Description("Kinetic Harvester")]
        KineticHarvester = 526,

        [Description("Resilience Harvester")]
        ResilienceHarvester = 527,

        [Description("Orb Enthusiast")]
        OrbEnthusiast = 528,

        [Description("Scrap Scrambler")]
        ScrapScrambler = 529,

        [Description("Solution Gambler")]
        SolutionGambler = 530,

        [Description("Autotank")]
        Autotank = 531,

        [Description("Spent Autotank")]
        SpentAutotank = 534,

        [Description("Uncertain Blessing")]
        UncertainBlessing = 535,

        [Description("Prototype Resonator")]
        PrototypeResonator = 536,

        [Description("Protobalancer")]
        Protobalancer = 537,

        [Description("Shopsmasher")]
        Shopsmasher = 538,

        [Description("Speed Demon")]
        SpeedDemon = 539,

        [Description("Unstoppable Force")]
        UnstoppableForce2 = 540,

        [Description("Coup de Grace")]
        CoupdeGrace = 541,

        [Description("Thrill of Battle")]
        ThrillofBattle = 542,

        [Description("Barbarian's Resolve")]
        BarbariansResolve = 543,

        [Description("Juggernaut")]
        Juggernaut = 544,

        [Description("Mind Palace")]
        MindPalace = 545,

        [Description("Fatal Fury")]
        FatalFury = 546,

        [Description("Excitement Engine")]
        ExcitementEngine = 547,

        [Description("Calculated Strike")]
        CalculatedStrike = 548,

        [Description("Burn for Glory")]
        BurnforGlory = 549,

        [Description("Grazing Harvester")]
        GrazingHarvester = 550,

        [Description("Blood Price")]
        BloodPrice = 551,

        [Description("Greased Fate")]
        GreasedFate = 552,

        [Description("Counterstrike")]
        Counterstrike = 553,

        [Description("Top Shelf")]
        TopShelf = 554,

        [Description("Shield Bash")]
        ShieldBash = 555,

        [Description("Crisis Clarity")]
        CrisisClarity = 556,

        [Description("Pain Circuit")]
        PainCircuit = 557,

        [Description("Rage Circuit")]
        RageCircuit = 558,

        [Description("Scrap Trawler")]
        ScrapTrawler = 559,

        [Description("Charisma Protocol")]
        CharismaProtocol = 560,

        [Description("Armor Integrator")]
        ArmorIntegrator = 561,

        [Description("Autocompleter")]
        Autocompleter = 562,

        [Description("Scrap Sleuth")]
        ScrapSleuth = 563,

        [Description("Smuggler Attractor")]
        SmugglerAttractor = 564,

        [Description("Scrappy Scrapper")]
        ScrappyScrapper = 565,

        [Description("Useless Garbage")]
        UselessGarbage = 566,

        [Description("Into the Fray")]
        IntotheFray = 567,

        [Description("Patient Hunter")]
        PatientHunter = 568,

        [Description("Doppelgel")]
        Doppelgel = 569,

        [Description("Challenger's Banner")]
        ChallengersBanner = 570,

        [Description("Superweight")]
        Superweight = 571,

        [Description("CQC Enthusiast")]
        CqcEnthusiast = 650,

        [Description("Combo Demon")]
        ComboDemon = 651,

        [Description("Zephyr")]
        Zephyr2 = 652,

        [Description("Secret Techniques")]
        SecretTechniques = 653,

        [Description("Surging Lubricant")]
        SurgingLubricant = 654,

        [Description("Pressure Strikes")]
        PressureStrikes = 655,

        [Description("Barrel Grease")]
        BarrelGrease = 675,

        [Description("Power Purist")]
        PowerPurist = 676,

        [Description("Vibrodecay")]
        Vibrodecay = 677,

        [Description("Marksman's Might")]
        MarksmansMight = 678,

        [Description("Beam Enthusiast")]
        BeamEnthusiast = 679,

        [Description("Heavy Juice")]
        HeavyJuice = 680,

        [Description("Lil' Hoot")]
        LilHoot = 681,

        [Description("Penance")]
        Penance = 682,

        [Description("Facesmasher")]
        Facesmasher = 683,

        [Description("Grooving Pulsar")]
        GroovingPulsar = 684,

        [Description("Vital Crystal")]
        VitalCrystal = 685,

        [Description("Time Anchor")]
        TimeAnchor = 687,

        [Description("Chronopointer")]
        Chronopointer = 688,

        [Description("Hoot's Hourglass")]
        HootsHourglass = 689,

        [Description("Kinetic Desctructor")]
        KineticDesctructor = 690,

        [Description("Bounding Blaster")]
        BoundingBlaster = 691,

        [Description("Graceful Strikes")]
        GracefulStrikes = 692,

        [Description("Vibroharvester")]
        Vibroharvester = 693,

        [Description("Scrapbits")]
        Scrapbits = 695,

        [Description("Bashing Dash")]
        BashingDash = 725,

        [Description("Glory Enjoyer")]
        GloryEnjoyer = 726,

        [Description("Core Protector")]
        CoreProtector = 727,

        [Description("Core Aggressor")]
        CoreAggressor = 728,

        [Description("Core Collector")]
        CoreCollector = 729,

        [Description("Efficient Attacker")]
        EfficientAttacker = 730,

        [Description("Power Dasher")]
        PowerDasher = 731,

        [Description("Vital Scrapper")]
        VitalScrapper = 732,

        [Description("Energized Scrapper")]
        EnergizedScrapper = 733,

        [Description("Efficient Restorer")]
        EfficientRestorer = 734,

        [Description("Corogel")]
        Corogel = 735,

        [Description("Friendogel")]
        Friendogel = 736,

        [Description("Triplicate Spirits")]
        TriplicateSpirits = 737,

        [Description("Value Detector")]
        ValueDetector = 738,

        [Description("Glorious Convocation")]
        GloriousConvocation = 739,

        [Description("Unspeakable Act")]
        UnspeakableAct = 740,

        [Description("Glorious Production")]
        GloriousProduction = 741,

        [Description("Deadly Momentum")]
        DeadlyMomentum = 742,

        [Description("Riotous Bulwark")]
        RiotousBulwark = 743,

        [Description("Armoreal Pod")]
        ArmorealPod = 744,

        [Description("Decorative Plating")]
        DecorativePlating = 745,

        [Description("High Roller")]
        HighRoller = 746,

        [Description("It's Egg!")]
        ItsEgg = 747,

        [Description("Unstable Defense")]
        UnstableDefense = 748,

        [Description("Force")]
        Force = 750,

        [Description("Sagelens")]
        Sagelens = 751,

        [Description("Clover")]
        Clover = 752,

        [Description("Nutfinder")]
        Nutfinder = 753,

        [Description("Core")]
        Core = 754,

        [Description("Hysteria")]
        Hysteria = 755,

        [Description("Mender")]
        Mender = 756,

        [Description("Everfont")]
        Everfont = 757,

        [Description("Grab Bag")]
        GrabBag = 758,

        [Description("Archive")]
        Archive = 759,

        [Description("Utilifier Max")]
        UtilifierMax = 760,

        [Description("Gears of Industry")]
        GearsofIndustry = 761,

        [Description("Market Fluctuations")]
        MarketFluctuations = 762,

        [Description("Grey Goo")]
        GreyGoo = 763,

        [Description("Focused Repair")]
        FocusedRepair = 764,

        [Description("Elliecare")]
        Elliecare = 765,

        [Description("Healing Flair")]
        HealingFlair = 766,

        [Description("Mobility Repositioner")]
        MobilityRepositioner = 767,

        [Description("Vibrodevourer")]
        Vibrodevourer = 768,

        [Description("Final Bargain")]
        FinalBargain = 769,

        [Description("Vital Gambit")]
        VitalGambit = 770,

        [Description("Warping Waters")]
        WarpingWaters = 771,

        [Description("Stalwart Waters")]
        StalwartWaters = 772,

        [Description("Oops! All Refunds")]
        OopsAllRefunds = 773,

        [Description("Burn for Glory")]
        BurnforGlory2 = 774,

        [Description("Crushing Hysteria")]
        CrushingHysteria = 775,

        [Description("Flaring Hysteria")]
        FlaringHysteria = 776,

        [Description("Vexing Clover")]
        VexingClover = 777,

        [Description("Wincing Clover")]
        WincingClover = 778,

        [Description("Kinghealer")]
        Kinghealer = 779,

        [Description("Patchwork Overloader")]
        PatchworkOverloader = 780,

        [Description("Patchwork Contract")]
        PatchworkContract = 781,

        [Description("Consuming Stamina")]
        ConsumingStamina = 782,

        [Description("Consuming Habits")]
        ConsumingHabits = 783,

        [Description("Blue Streak")]
        BlueStreak = 784,

        [Description("Fresh Moves")]
        FreshMoves = 785,

        [Description("Charging Force")]
        ChargingForce = 786,

        [Description("Autoloader")]
        Autoloader = 787,

        [Description("Earthmetal Plating")]
        EarthmetalPlating = 788,

        [Description("Patchwork Integrator")]
        PatchworkIntegrator = 789,

        [Description("Consuming Fury")]
        ConsumingFury = 790,

        [Description("Kingseeker")]
        Kingseeker = 791,

        [Description("Defiant Decree")]
        DefiantDecree = 792,

        [Description("Violence Enhancer")]
        ViolenceEnhancer = 793,

        [Description("Uncharging Force")]
        UnchargingForce = 794,

        [Description("Blinding Hysteria")]
        BlindingHysteria = 795,

        [Description("Solution Gambler")]
        SolutionGambler2 = 796,

        [Description("Grey Goo")]
        GreyGoo2 = 797,

        [Description("The One and Only")]
        TheOneandOnly = 798,

        [Description("Debilitating")]
        Debilitating = 800,

        [Description("Defiant")]
        Defiant = 801,

        [Description("Famished")]
        Famished = 802,

        [Description("Powerless")]
        Powerless = 803,

        [Description("Noodly")]
        Noodly = 804,

        [Description("Outcast")]
        Outcast = 805,

        [Description("Immaterial")]
        Immaterial = 806,

        [Description("Uncharging")]
        Uncharging = 807,

        [Description("Stoic")]
        Stoic = 808,

        [Description("Fragile")]
        Fragile = 809,

        [Description("Purifying")]
        Purifying = 810,

        [Description("Thieving")]
        Thieving = 811,

        [Description("Edges of Madness")]
        EdgesofMadness = 812,

        [Description("Final Shell")]
        FinalShell = 813,

        [Description("Purifying Waters")]
        PurifyingWaters = 814,

        [Description("Contractor Beta")]
        ContractorBeta = 815,

        [Description("Zookeeper's Burden")]
        ZookeepersBurden = 816,

        [Description("Symbol of Submission")]
        SymbolofSubmission = 817,

        [Description("Symbol of Peace")]
        SymbolofPeace = 818,

        [Description("Best Friend")]
        BestFriend = 819,

        [Description("Tick, Tock")]
        TickTock = 820,

        [Description("Brittle Guard")]
        BrittleGuard = 821,

        [Description("Madness Fountain")]
        MadnessFountain = 822,

        [Description("Rage Insurance")]
        RageInsurance = 823,

        [Description("datalore received")]
        Datalorereceived = 850,

        [Description("Armor Capsule")]
        ArmorCapsule = 851,

        [Description("Potentia Fragments")]
        PotentiaFragments = 852,

        [Description("Titan Shards")]
        TitanShards = 853,

        [Description("Armatort's Shell")]
        ArmatortsShell = 865,

        [Description("Oxjack's Guile")]
        OxjacksGuile = 866,

        [Description("Dracopent's Pride")]
        DracopentsPride = 867,

        [Description("Owlhawk's Reign")]
        OwlhawksReign = 868,

        [Description("Armatort's Dome")]
        ArmatortsDome = 869,

        [Description("Oxjack's Ken")]
        OxjacksKen = 870,

        [Description("Dracopent's Fang")]
        DracopentsFang = 871,

        [Description("Owlhawk's Focus")]
        OwlhawksFocus = 872,

        [Description("Armatort's Momentum")]
        ArmatortsMomentum = 873,

        [Description("Oxjack's Blitz")]
        OxjacksBlitz = 874,

        [Description("Dracopent's Bound")]
        DracopentsBound = 875,

        [Description("Owlhawk's Feather")]
        OwlhawksFeather = 876,

        [Description("Armatort's Pound")]
        ArmatortsPound = 877,

        [Description("Oxjack's Fury")]
        OxjacksFury = 878,

        [Description("Dracopent's Claw")]
        DracopentsClaw = 879,

        [Description("Owlhawk's Talon")]
        OwlhawksTalon = 880,

        [Description("Armatort's Wish")]
        ArmatortsWish = 881,

        [Description("Oxjack's Wish")]
        OxjacksWish = 882,

        [Description("Dracopent's Wish")]
        DracopentsWish = 883,

        [Description("Owlhawk's Wish")]
        OwlhawksWish = 884,

        [Description("Harmony Circuit")]
        HarmonyCircuit = 885,

        [Description("Big Chunk")]
        BigChunk = 886,

        [Description("Vagrant's Yearn")]
        VagrantsYearn = 887,

        [Description("Vagrant's Sonata")]
        VagrantsSonata = 888,

        [Description("Vagrant's Waltz")]
        VagrantsWaltz = 889,

        [Description("Vagrant's Dissonance")]
        VagrantsDissonance = 890,

        [Description("Zookeeper's Phalanx")]
        ZookeepersPhalanx = 891,

        [Description("Zookeeper's Command")]
        ZookeepersCommand = 892,

        [Description("Zookeeper's March")]
        ZookeepersMarch = 893,

        [Description("Zookeeper's Wrath")]
        ZookeepersWrath = 894,

        [Description("Scrooge's Insurance")]
        ScroogesInsurance = 895,

        [Description("Scrooge's Bounty")]
        ScroogesBounty = 896,

        [Description("Scrooge's Bootstrap")]
        ScroogesBootstrap = 897,

        [Description("Scrooge's Wager")]
        ScroogesWager = 898,

        [Description("No Arms Aug")]
        NoArmsAug = 899,

        [Description("No Body Aug")]
        NoBodyAug = 900,

        [Description("No Legs Aug")]
        NoLegsAug = 901,

        [Description("No Head Aug")]
        NoHeadAug = 902,

        [Description("Armatort, the Unstoppable")]
        ArmatorttheUnstoppable = 903,

        [Description("Oxjack, the Flash")]
        OxjacktheFlash = 904,

        [Description("Dracopent, the Foul")]
        DracopenttheFoul = 905,

        [Description("Owlhawk, the Wise")]
        OwlhawktheWise = 906,

        [Description("Remnant of Flame")]
        RemnantofFlame = 909,

        [Description("Remnant of Sound")]
        RemnantofSound = 910,

        [Description("Remnant of Time")]
        RemnantofTime = 911,

        [Description("Remnant of Wind")]
        RemnantofWind = 912,

        [Description("Remnant of Spirit")]
        RemnantofSpirit = 913,

        [Description("Remnant of Kindness")]
        RemnantofKindness = 914,

        [Description("Remnant of Determination")]
        RemnantofDetermination = 915,

        [Description("Remnant of Sorrow")]
        RemnantofSorrow = 916,

        [Description("Wild Mortar")]
        WildMortar = 917,

        [Description("Serene Mortar")]
        SereneMortar = 918,

        [Description("Crystal Chains")]
        CrystalChains = 920,

        [Description("Unyielding Wave")]
        UnyieldingWave = 921,

        [Description("Metal Gear")]
        MetalGear = 923,

        [Description("Disruptor Gear")]
        DisruptorGear = 924,

        [Description("Whirlspur")]
        Whirlspur = 926,

        [Description("Unending Whirl")]
        UnendingWhirl = 927,

        [Description("Desperate Void")]
        DesperateVoid = 929,

        [Description("Efficient Void")]
        EfficientVoid = 930,

        [Description("Mirror Pulse")]
        MirrorPulse = 932,

        [Description("Pulse Engine")]
        PulseEngine = 933,

        [Description("Bouncing Bolt")]
        BouncingBolt = 935,

        [Description("Supersonic Bolt")]
        SupersonicBolt = 936,

        [Description("Vicious Drone")]
        ViciousDrone = 938,

        [Description("Devoted Drone")]
        DevotedDrone = 939,

        [Description("Furious Ascent")]
        FuriousAscent = 941,

        [Description("Redeemer's Ascent")]
        RedeemersAscent = 942,

        [Description("Mobile Shell")]
        MobileShell = 944,

        [Description("Mirror Shell")]
        MirrorShell = 945,

        [Description("Severing Link")]
        SeveringLink = 947,

        [Description("Shield Link")]
        ShieldLink = 948,

        [Description("Stormherald")]
        Stormherald = 950,

        [Description("Raijin Engine")]
        RaijinEngine = 951,

        [Description("Hungering Void")]
        HungeringVoid = 953,

        [Description("Void Persistence")]
        VoidPersistence = 954,

        [Description("Geoshift")]
        Geoshift = 956,

        [Description("Shaded Strikes")]
        ShadedStrikes = 957,

        [Description("Falling Star")]
        FallingStar = 959,

        [Description("Astral Terminus")]
        AstralTerminus = 960,

        [Description("Sacred Minnow")]
        SacredMinnow = 962,

        [Description("Enter the Void")]
        EntertheVoid = 963,

        [Description("Saber Impulse")]
        SaberImpulse = 965,

        [Description("Resonant Saber")]
        ResonantSaber = 966,

        [Description("Super Tonbo")]
        SuperTonbo = 967,

        [Description("Deadly Precision")]
        DeadlyPrecision = 968,

        [Description("Wavethrower")]
        Wavethrower = 969,

        [Description("Shock Actuator")]
        ShockActuator = 970,

        [Description("Effortless Blades")]
        EffortlessBlades = 971,

        [Description("Phase Knives")]
        PhaseKnives = 972,

        [Description("Lingering Fist")]
        LingeringFist = 973,

        [Description("Rapid Fist")]
        RapidFist = 974,

        [Description("Cycling Edge")]
        CyclingEdge = 975,

        [Description("Magnetic Edge")]
        MagneticEdge = 976,

        [Description("Lethal Evade")]
        LethalEvade = 977,

        [Description("Critical Blade")]
        CriticalBlade = 978,

        [Description("Reaper's Call")]
        ReapersCall = 979,

        [Description("Graceful Spinning")]
        GracefulSpinning = 980,

        [Description("Chainbind")]
        Chainbind = 981,

        [Description("Stylestrike")]
        Stylestrike = 982
    }
}