namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// unit ID.
    /// </summary>
    public enum unit
    {
        /// <summary>
        /// unknown unit
        /// </summary>
        unknown,

        // SystemDefinedConstants /////////////////////////////////////////////

        /// <summary>
        /// unique unit : ユニークユニット
        /// </summary>
        my_unique_unit,

        /// <summary>
        /// elite unique unit : エリートユニークユニット
        /// </summary>
        my_elite_unique_unit,

        /// <summary>
        /// unique unit line : ユニークユニット系列
        /// </summary>
        my_unique_unit_line,

        // defined by defconst ////////////////////////////////////////////////

        /// <summary>
        /// ShepherdMan : 羊を狩る人(男)
        /// </summary>
        ShepherdMan = 592,

        /// <summary>
        /// ShepherdWoman : 羊を狩る人(女)
        /// </summary>
        ShepherdWoman = 590,

        /// <summary>
        /// HarvesterMan : 苺を採る人(男)
        /// </summary>
        HarvesterMan = 120,

        /// <summary>
        /// HarvesterWoman : 苺を採る人(女)
        /// </summary>
        HarvesterWoman = 354,

        /// <summary>
        /// HunterMan : 狩りをする人(男)
        /// </summary>
        HunterMan = 122,

        /// <summary>
        /// HunterWoman : 狩りをする人(女)
        /// </summary>
        HunterWoman = 216,

        /// <summary>
        /// FisherMan : 漁をする人(男)
        /// </summary>
        FisherMan = 56,

        /// <summary>
        /// FisherWoman : 漁をする人(女)
        /// </summary>
        FisherWoman = 57,

        /// <summary>
        /// FarmerMan : 耕す人(男)
        /// </summary>
        FarmerMan = 214,

        /// <summary>
        /// FarmerWoman : 耕す人(女)
        /// </summary>
        FarmerWoman = 259,

        /// <summary>
        /// LumberjackMan : 木を切る人(男)
        /// </summary>
        LumberjackMan = 123,

        /// <summary>
        /// LumberjackWonam : 木を切る人(女)
        /// </summary>
        LumberjackWonam = 218,

        /// <summary>
        /// GoldMinerMan : 金を掘る人(男)
        /// </summary>
        GoldMinerMan = 579,

        /// <summary>
        /// GoldMinerWoman : 金を掘る人(女)
        /// </summary>
        GoldMinerWoman = 581,

        /// <summary>
        /// StoneMinerMan : 石を掘る人(男)
        /// </summary>
        StoneMinerMan = 124,

        /// <summary>
        /// StoneMinerWoman : 石を掘る人(女)
        /// </summary>
        StoneMinerWoman = 220,

        /// <summary>
        /// BuilderMan : 建築する人(男)
        /// </summary>
        BuilderMan = 118,

        /// <summary>
        /// BuilderWoman : 建築する人(女)
        /// </summary>
        BuilderWoman = 212,

        /// <summary>
        /// RepairMan : 補修する人(男)
        /// </summary>
        RepairMan = 156,

        /// <summary>
        /// RepairWoman : 補修する人(女)
        /// </summary>
        RepairWoman = 222,

#if false
        /// <summary>
        ///待機中の人(男)
        ///町の人(<seealso cref="villager"/>)と同じIDのため機能しない
        /// </summary>
        WaitingMan = 83,
#endif

        /// <summary>
        /// WaitingWoman : 待機中の人(女)
        /// </summary>
        WaitingWoman = 293,

        // unit parameter /////////////////////////////////////////////////////

        /// <summary>
        /// trade cart : 荷馬車(積荷なし)
        /// </summary>
        trade_cart = 128,

        /// <summary>
        /// monk : 聖職者 (100G)
        /// </summary>
        monk = 125,

        /// <summary>
        /// missionary : 宣教師
        /// </summary>
        missionary = 775,

        /// <summary>
        /// militiaman : 民兵 (60F, 20G)
        /// </summary>
        militiaman = 74,

        /// <summary>
        /// man at arms : 軍兵 (60F, 20G)
        /// <para>
        /// Up grade from <see cref="militiaman"/> (100F, 40G)
        /// </para>
        /// </summary>
        man_at_arms = 75,

        /// <summary>
        /// long swordsman : 長剣剣士 (60F, 20G)
        /// <para>
        /// Up grade from <see cref="man_at_arms"/> (200F, 65G)
        /// </para>
        /// </summary>
        long_swordsman = 77,

        /// <summary>
        /// two handed swordsman : 重剣剣士 (60F, 20G)
        /// <para>
        /// Up grade from <see cref="long_swordsman"/> (300F, 100G)
        /// </para>
        /// </summary>
        two_handed_swordsman = 473,

        /// <summary>
        /// champion : 近衛剣士 (60F, 20G)
        /// <para>
        /// Up grade from <see cref="two_handed_swordsman"/> (750F, 350G)
        /// </para>
        /// </summary>
        champion = 567,

        /// <summary>
        /// spearman : 槍兵 (35F, 25W)
        /// </summary>
        spearman = 93,

        /// <summary>
        /// pikeman : 長槍兵 (35F, 25W)
        /// <para>
        /// Up grade from <see cref="spearman"/> (215F, 90G)
        /// </para>
        /// </summary>
        pikeman = 358,

        /// <summary>
        /// halberdier : 矛槍兵 (35F, 25W)
        /// <para>
        /// Up grade from <see cref="pikeman"/> (300F, 600G)
        /// </para>
        /// </summary>
        halberdier = 359,

        /// <summary>
        /// eagle warrior : イーグルウォリア (20F, 50G)
        /// </summary>
        eagle_warrior = 751,

        /// <summary>
        /// elite eagle warrior : エリートイーグルウォリア (20F, 50G)
        /// </summary>
        elite_eagle_warrior = 752,

        /// <summary>
        /// huskarl : ハスカール
        /// </summary>
        huskarl = 41,

        /// <summary>
        /// elite huskarl : エリートハスカール
        /// </summary>
        elite_huskarl = 555,

        /// <summary>
        /// berserk : ベルセルク
        /// </summary>
        berserk = 692,

        /// <summary>
        /// elite berserk : エリートベルセルク
        /// </summary>
        elite_berserk = 694,

        /// <summary>
        /// jaguar man : ジャガーウォリア
        /// </summary>
        jaguar_man = 725,

        /// <summary>
        /// elite jaguar man : エリートジャガーウォリア
        /// </summary>
        elite_jaguar_man = 726,

        /// <summary>
        /// samurai : 武士
        /// </summary>
        samurai = 291,

        /// <summary>
        /// elite samurai : 剣豪
        /// </summary>
        elite_samurai = 560,

        /// <summary>
        /// teutonic knight : チュートンナイト
        /// </summary>
        teutonic_knight = 25,

        /// <summary>
        /// elite teutonic knight : エリートチュートンナイト
        /// </summary>
        elite_teutonic_knight = 554,

        /// <summary>
        /// throwing axeman : フランカスロウ
        /// </summary>
        throwing_axeman = 281,

        /// <summary>
        /// elite throwing axeman : エリートフランカスロウ
        /// </summary>
        elite_throwing_axeman = 531,

        /// <summary>
        /// woad raider : ウォードレイダー
        /// </summary>
        woad_raider = 232,

        /// <summary>
        /// elite woad raider : エリートウォードレイダー
        /// </summary>
        elite_woad_raider = 534,

        /// <summary>
        /// archer : 射手 (25W, 45G)
        /// </summary>
        archer = 4,

        /// <summary>
        /// crossbowman : 石弓射手 (25W, 45G)
        /// <para>
        /// Up grade from <see cref="archer"/> (125F, 75G)
        /// </para>
        /// </summary>
        crossbowman = 24,

        /// <summary>
        /// arbalest : 重石弓射手 (25W, 45G)
        /// <para>
        /// Up grade from <see cref="archer"/> (350F, 300G)
        /// </para>
        /// </summary>
        arbalest = 492,

        /// <summary>
        /// skirmisher : 散兵 (25F, 35W)
        /// </summary>
        skirmisher = 7,

        /// <summary>
        /// elite skirmisher : 精鋭散兵 (25F, 35W)
        /// <para>
        /// Up grade from <see cref="skirmisher"/> (200F, 100G)
        /// </para>
        /// </summary>
        elite_skirmisher = 6,

        /// <summary>
        /// chu ko nu : 連弩兵
        /// </summary>
        chu_ko_nu = 73,

        /// <summary>
        /// elite chu ko nu : 改良型連弩兵
        /// </summary>
        elite_chu_ko_nu = 559,

        /// <summary>
        /// longbowman : ロングボウ
        /// </summary>
        longbowman = 8,

        /// <summary>
        /// elite longbowman : エリートロングボウ
        /// </summary>
        elite_longbowman = 530,

        /// <summary>
        /// plumed archer : 羽飾射手
        /// </summary>
        plumed_archer = 763,

        /// <summary>
        /// elite plumed archer : 精鋭羽飾射手
        /// </summary>
        elite_plumed_archer = 765,

        /// <summary>
        /// cavalry archer : 弓騎兵
        /// </summary>
        cavalry_archer = 39,

        /// <summary>
        /// heavy cavalry archer : 重弓騎兵
        /// </summary>
        heavy_cavalry_archer = 474,

        /// <summary>
        /// mangudai : マングダイ
        /// </summary>
        mangudai = 11,

        /// <summary>
        /// elite mangudai : エリートマングダイ
        /// </summary>
        elite_mangudai = 561,

        /// <summary>
        /// war wagon : 戦車
        /// </summary>
        war_wagon = 827,

        /// <summary>
        /// elite war wagon : 強化戦車
        /// </summary>
        elite_war_wagon = 829,

        /// <summary>
        /// hand cannoneer : 砲撃手 (45F, 50G)
        /// </summary>
        hand_cannoneer = 5,

        /// <summary>
        /// janissary : イュニチェリ
        /// </summary>
        janissary = 46,

        /// <summary>
        /// elite janissary : エリートイュニチェリ
        /// </summary>
        elite_janissary = 557,

        /// <summary>
        /// conquistador : コンキスタドール
        /// </summary>
        conquistador = 771,

        /// <summary>
        /// elite conquistador : エリートコンキスタドール
        /// </summary>
        elite_conquistador = 773,

        /// <summary>
        /// scout cavalry : 斥候 (80F)
        /// </summary>
        scout_cavalry = 448,

        /// <summary>
        /// light cavalry : 騎兵 (80F)
        /// <para>
        /// Up grade from <see cref="scout_cavalry"/> (150F, 50G)
        /// </para>
        /// </summary>
        light_cavalry = 546,

        /// <summary>
        /// hussar : ハサー (80F)
        /// <para>
        /// Up grade from <see cref="light_cavalry"/> (500F, 600G)
        /// </para>
        /// </summary>
        hussar = 441,

        /// <summary>
        /// knight : 騎士 (60F, 75G)
        /// </summary>
        knight = 38,

        /// <summary>
        /// cavalier : 重騎士 (60F, 75G)
        /// <para>
        /// Up grade from <see cref="knight"/> (300F, 300G)
        /// </para>
        /// </summary>
        cavalier = 283,

        /// <summary>
        /// paladin : 近衛騎士 (60F, 75G)
        /// <para>
        /// Up grade from <see cref="cavalier"/> (1300F, 750G)
        /// </para>
        /// </summary>
        paladin = 569,

        /// <summary>
        /// camel : らくだ騎兵 (55F, 60G)
        /// </summary>
        camel = 329,

        /// <summary>
        /// heavy camel : 重装らくだ騎兵 (55F, 60G)
        /// <para>
        /// Up grade from <see cref="camel"/> (325F, 360G)
        /// </para>
        /// </summary>
        heavy_camel = 330,

        /// <summary>
        /// cataphract : カタフラクト
        /// </summary>
        cataphract = 40,

        /// <summary>
        /// elite cataphract : エリートカタフラクト
        /// </summary>
        elite_cataphract = 553,

        /// <summary>
        /// mameluke : マムルーク
        /// </summary>
        mameluke = 282,

        /// <summary>
        /// elite mameluke : エリートマムルーク
        /// </summary>
        elite_mameluke = 556,

        /// <summary>
        /// tarkan : タルカン
        /// </summary>
        tarkan = 755,

        /// <summary>
        /// elite tarkan : エリートタルカン
        /// </summary>
        elite_tarkan = 757,

        /// <summary>
        /// war elephant : エレファント
        /// </summary>
        war_elephant = 239,

        /// <summary>
        /// elite war elephant : エリートエレファント
        /// </summary>
        elite_war_elephant = 558,

        /// <summary>
        /// battering ram : 破城槌 (160W, 75G)
        /// </summary>
        battering_ram = 35,

        /// <summary>
        /// capped ram : 強化破城槌 (160W, 75G)
        /// <para>
        /// Up grade from <see cref="battering_ram"/> (300F)
        /// </para>
        /// </summary>
        capped_ram = 422,

        /// <summary>
        /// siege ram : 改良強化破城槌 (160W, 75G)
        /// <para>
        /// Up grade from <see cref="capped_ram"/> (1000F)
        /// </para>
        /// </summary>
        siege_ram = 548,

        /// <summary>
        /// mangonel : 投石機 (160W, 135G)
        /// </summary>
        mangonel = 280,

        /// <summary>
        /// onager : 改良型投石機 (160W, 135G)
        /// <para>
        /// Up grade from <see cref="mangonel"/> (800F, 500G)
        /// </para>
        /// </summary>
        onager = 550,

        /// <summary>
        /// siege onager : 破城投石機 (160W, 135G)
        /// <para>
        /// Up grade from <see cref="onager"/> (1450F, 1000G)
        /// </para>
        /// </summary>
        siege_onager = 588,

        /// <summary>
        /// bombard cannon : 大砲 (225W, 225G)
        /// </summary>
        bombard_cannon = 36,

        /// <summary>
        /// scorpion : スコーピオン (75W, 75G)
        /// </summary>
        scorpion = 279,

        /// <summary>
        /// heavy scorpion : ヘビースコーピオン (75W, 75G)
        /// <para>
        /// Up grade from <see cref="scorpion"/> (1000F, 1000W)
        /// </para>
        /// </summary>
        heavy_scorpion = 542,

        /// <summary>
        /// petard : 爆破工作兵 (65F, 20G)
        /// </summary>
        petard = 440,

        /// <summary>
        /// trebuchet : 遠投投石機(梱包) (200F, 200G)
        /// </summary>
        trebuchet = 331,

        /// <summary>
        /// fishing ship : 漁船 (75W)
        /// </summary>
        fishing_ship = 13,

        /// <summary>
        /// trade cog : 交易貨物船 (100W, 50G)
        /// </summary>
        trade_cog = 17,

        /// <summary>
        /// transport ship : 輸送船 (125W)
        /// </summary>
        transport_ship = 545,

        /// <summary>
        /// galley : ガレー船 (90W, 30G)
        /// </summary>
        galley = 539,

        /// <summary>
        /// war galley : 大型ガレー船 (90W, 30G)
        /// <para>
        /// Up grade from <see cref="galley"/> (230F, 100G)
        /// </para>
        /// </summary>
        war_galley = 21,

        /// <summary>
        /// galleon : ガレオン船 (90W, 30G)
        /// <para>
        /// Up grade from <see cref="war_galley"/> (400F, 315G)
        /// </para>
        /// </summary>
        galleon = 442,

        /// <summary>
        /// demolition ship : 爆破工作船 (70W, 50G)
        /// </summary>
        demolition_ship = 527,

        /// <summary>
        /// heavy demolition ship : 重装爆破工作船 (70W, 50G)
        /// <para>
        /// Up grade from <see cref="demolition_ship"/> (230F, 100G)
        /// </para>
        /// </summary>
        heavy_demolition_ship = 528,

        /// <summary>
        /// fire_ship : 火炎船 (75W, 45G)
        /// </summary>
        fire_ship = 529,

        /// <summary>
        /// fast fire ship : 高速火炎船 (75W, 45G)
        /// <para>
        /// Up grade from <see cref="fire_ship"/> (280W, 250G)
        /// </para>
        /// </summary>
        fast_fire_ship = 532,

        /// <summary>
        /// cannon galleon : キャノンガリオン船 (200W, 150G)
        /// <para>
        /// Up grade need <see cref="ri.chemistry"/> and (400F, 500W)
        /// </para>
        /// </summary>
        cannon_galleon = 420,

        /// <summary>
        /// elite cannon galleon : 機動キャノンガリオン船 (200W, 150G)
        /// <para>
        /// Up grade from <see cref="cannon_galleon"/> (525W, 500G)
        /// </para>
        /// </summary>
        elite_cannon_galleon = 691,

        /// <summary>
        /// longboat : バイキング船
        /// </summary>
        longboat = 250,

        /// <summary>
        /// elite_longboat : 重装バイキング船
        /// </summary>
        elite_longboat = 533,

        /// <summary>
        /// turtle_ship : 亀甲船
        /// </summary>
        turtle_ship = 831,

        /// <summary>
        /// elite_turtle_ship : 重装亀甲船
        /// </summary>
        elite_turtle_ship = 832,

        /// <summary>
        /// villager : 町の人 (50F)
        /// </summary>
        villager = 83,

        // Line ID /////////////////////////////////////////////////////////////

        /// <summary>
        /// militiaman_line : 民兵系
        /// </summary>
        militiaman_line = -296,

        /// <summary>
        /// spearman_line : 槍兵系
        /// </summary>
        spearman_line = -295,

        /// <summary>
        /// eagle_warrior_line : イーグルウォリア系
        /// </summary>
        eagle_warrior_line = -267,

        /// <summary>
        /// huskarl_line : ハスカール系
        /// </summary>
        huskarl_line = -279,

        /// <summary>
        /// berserk_line : ベルセルク系
        /// </summary>
        berserk_line = -282,

        /// <summary>
        /// jaguar_man_line : ジャガーウォリア系
        /// </summary>
        jaguar_man_line = -268,

        /// <summary>
        /// samurai_line : 武士系
        /// </summary>
        samurai_line = -274,

        /// <summary>
        /// teutonic_knight_line : チュートンナイト系
        /// </summary>
        teutonic_knight_line = -273,

        /// <summary>
        /// throwing_axeman_line : フランカスロウ系
        /// </summary>
        throwing_axeman_line = -272,

        /// <summary>
        /// woad_raider_line : ウォードレイダー系
        /// </summary>
        woad_raider_line = -269,

        /// <summary>
        /// archer_line : 射手系
        /// </summary>
        archer_line = -299,

        /// <summary>
        /// skirmisher_line : 散兵系
        /// </summary>
        skirmisher_line = -297,

        /// <summary>
        /// chu_ko_nu_line : 連弩兵系
        /// </summary>
        chu_ko_nu_line = -280,

        /// <summary>
        /// longbowman_line : ロングボウ系
        /// </summary>
        longbowman_line = -277,

        /// <summary>
        /// plumed_archer_line : 羽飾射手系
        /// </summary>
        plumed_archer_line = -266,

        /// <summary>
        /// cavalry_archer_line : 弓騎兵系
        /// </summary>
        cavalry_archer_line = -298,

        /// <summary>
        /// mangudai_line : マングダイ系
        /// </summary>
        mangudai_line = -275,

        /// <summary>
        /// war_wagon_line : 戦車系
        /// </summary>
        war_wagon_line = -270,

        /// <summary>
        /// janissary_line : イュニチェリ系
        /// </summary>
        janissary_line = -278,

        /// <summary>
        /// conquistador_line : コンキスタドール系
        /// </summary>
        conquistador_line = -264,

        /// <summary>
        /// scout_cavalry_line : 斥候系
        /// </summary>
        scout_cavalry_line = -286,

        /// <summary>
        /// knight_line: 騎士系
        /// </summary>
        knight_line = -287,

        /// <summary>
        /// camel_line : らくだ騎兵系
        /// </summary>
        camel_line = -288,

        /// <summary>
        /// cataphract_line : カタフラクト系
        /// </summary>
        cataphract_line = -281,

        /// <summary>
        /// mameluke_line : マムルーク系
        /// </summary>
        mameluke_line = -276,

        /// <summary>
        /// tarkan_line : タルカン系
        /// </summary>
        tarkan_line = -265,

        /// <summary>
        /// war_elephant_line : エレファント系
        /// </summary>
        war_elephant_line = -271,

        /// <summary>
        /// battering_ram_line : 破城槌系
        /// </summary>
        battering_ram_line = -291,

        /// <summary>
        /// mangonel_line : 投石機系
        /// </summary>
        mangonel_line = -290,

        /// <summary>
        /// scorpion_line : スコーピオン系
        /// </summary>
        scorpion_line = -289,

        /// <summary>
        /// galley_line : ガレー船系
        /// </summary>
        galley_line = -292,

        /// <summary>
        /// demolition_ship_line : 爆破工作船系
        /// </summary>
        demolition_ship_line = -294,

        /// <summary>
        /// fire_ship_line : 火炎船系
        /// </summary>
        fire_ship_line = -293,

        /// <summary>
        /// cannon_galleon_line : キャノンガリオン船系
        /// </summary>
        cannon_galleon_line = -285,

        /// <summary>
        /// longboat_line : バイキング船系
        /// </summary>
        longboat_line = -284,

        /// <summary>
        /// turtle_ship_line : 亀甲船系
        /// </summary>
        turtle_ship_line = -283,

        /// <summary>
        /// Infantry group : 歩兵グループ
        /// </summary>
        InfantryGroup = 906,

        /// <summary>
        /// Archer group : 射手グループ
        /// </summary>
        ArcherGroup = 900,

        /// <summary>
        /// 騎兵系グループ
        /// </summary>
        CavalryGroup = 912,
    }
}
