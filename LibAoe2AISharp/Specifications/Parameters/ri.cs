namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Research ID.
    /// <para>
    /// "ri-" + enum ri member are generated as research IDs.
    /// </para>
    /// </summary>
    public enum ri
    {
        /// <summary>
        /// feudal age : 領主の時代
        /// </summary>
        feudal_age = 101,

        /// <summary>
        /// castle age : 城主の時代
        /// </summary>
        castle_age = 102,

        /// <summary>
        /// imperial age : 帝王の時代
        /// </summary>
        imperial_age = 103,

        /// <summary>
        /// loom : 機織り (50G)
        /// </summary>
        loom = 22,

        /// <summary>
        /// wheel barrow : 手押し車 (175F, 50W)
        /// <para>
        /// <see cref="wheel_barrow"/>
        /// ->
        /// <see cref="hand_cart"/>
        /// </para>
        /// </summary>
        wheel_barrow = 213,

        /// <summary>
        /// hand cart : 荷車 (300F, 200W)
        /// <para>
        /// <see cref="wheel_barrow"/>
        /// ->
        /// <see cref="hand_cart"/>
        /// </para>
        /// </summary>
        hand_cart = 249,

        /// <summary>
        /// town watch : 見張り (75F)
        /// <para>
        /// <see cref="town_watch"/>
        /// ->
        /// <see cref="town_patrol"/>
        /// </para>
        /// </summary>
        town_watch = 8,

        /// <summary>
        /// town patrol : 巡回 (300F, 100G)
        /// <para>
        /// <see cref="town_watch"/>
        /// ->
        /// <see cref="town_patrol"/>
        /// </para>
        /// </summary>
        town_patrol = 280,

        /// <summary>
        /// horse collar : 引き具 (75F, 75W)
        /// <para>
        /// <see cref="horse_collar"/>
        /// ->
        /// <see cref="heavy_plow"/>
        /// ->
        /// <see cref="crop_rotation"/>
        /// </para>
        /// </summary>
        horse_collar = 14,

        /// <summary>
        /// heavy plow : 馬鍬 (125F, 125W)
        /// <para>
        /// <see cref="horse_collar"/>
        /// ->
        /// <see cref="heavy_plow"/>
        /// ->
        /// <see cref="crop_rotation"/>
        /// </para>
        /// </summary>
        heavy_plow = 13,

        /// <summary>
        /// crop rotation : 輪作 (250F, 250W)
        /// <para>
        /// <see cref="horse_collar"/>
        /// ->
        /// <see cref="heavy_plow"/>
        /// ->
        /// <see cref="crop_rotation"/>
        /// </para>
        /// </summary>
        crop_rotation = 12,

        /// <summary>
        /// double bit axe : 両刃斧 (100F, 50W)
        /// <para>
        /// <see cref="double_bit_axe"/>
        /// ->
        /// <see cref="bow_saw"/>
        /// ->
        /// <see cref="two_man_saw"/>
        /// </para>
        /// </summary>
        double_bit_axe = 202,

        /// <summary>
        /// bow saw : のこぎり (150F, 100W)
        /// <para>
        /// <see cref="double_bit_axe"/>
        /// ->
        /// <see cref="bow_saw"/>
        /// ->
        /// <see cref="two_man_saw"/>
        /// </para>
        /// </summary>
        bow_saw = 203,

        /// <summary>
        /// two man saw : 両引きのこぎり (300F, 200W)
        /// <para>
        /// <see cref="double_bit_axe"/>
        /// ->
        /// <see cref="bow_saw"/>
        /// ->
        /// <see cref="two_man_saw"/>
        /// </para>
        /// </summary>
        two_man_saw = 221,

        /// <summary>
        /// gold mining : 金の採掘 (100F, 75W)
        /// <para>
        /// <see cref="gold_mining"/>
        /// ->
        /// <see cref="gold_shaft_mining"/>
        /// </para>
        /// </summary>
        gold_mining = 55,

        /// <summary>
        /// gold shaft mining : 金の掘削 (200F, 150W)
        /// <para>
        /// <see cref="gold_mining"/>
        /// ->
        /// <see cref="gold_shaft_mining"/>
        /// </para>
        /// </summary>
        gold_shaft_mining = 182,

        /// <summary>
        /// stone mining : 石の切り出し (100F, 75W)
        /// <para>
        /// <see cref="stone_mining"/>
        /// ->
        /// <see cref="stone_shaft_mining"/>
        /// </para>
        /// </summary>
        stone_mining = 278,

        /// <summary>
        /// stone shaft mining : 石の掘削 (200F, 150W)
        /// <para>
        /// <see cref="stone_mining"/>
        /// ->
        /// <see cref="stone_shaft_mining"/>
        /// </para>
        /// </summary>
        stone_shaft_mining = 279,

        /// <summary>
        /// cartography : 地図製作
        /// </summary>
        cartography = 19,

        /// <summary>
        /// coinage : 貨幣制度 (200F, 100G)
        /// </summary>
        coinage = 23,

        /// <summary>
        /// caravan : 隊商 (200F, 200G)
        /// </summary>
        caravan = 48,

        /// <summary>
        /// banking : 銀行取引 (300F, 200G)
        /// </summary>
        banking = 17,

        /// <summary>
        /// guilds : 組合 (300F, 200G)
        /// </summary>
        guilds = 15,

        /// <summary>
        /// padded archer armor : 射手用胸当て (100F)
        /// <para>
        /// <see cref="padded_archer_armor"/>
        /// ->
        /// <see cref="leather_archer_armor"/>
        /// ->
        /// <see cref="ring_archer_armor"/>
        /// </para>
        /// </summary>
        padded_archer_armor = 211,

        /// <summary>
        /// leather archer armor : 射手用革の鎧 (150F 150G)
        /// <para>
        /// <see cref="padded_archer_armor"/>
        /// ->
        /// <see cref="leather_archer_armor"/>
        /// ->
        /// <see cref="ring_archer_armor"/>
        /// </para>
        /// </summary>
        leather_archer_armor = 212,

        /// <summary>
        /// ring archer armor : 射手用鎖の鎧 (250F 250G)
        /// <para>
        /// <see cref="padded_archer_armor"/>
        /// ->
        /// <see cref="leather_archer_armor"/>
        /// ->
        /// <see cref="ring_archer_armor"/>
        /// </para>
        /// </summary>
        ring_archer_armor = 219,

        /// <summary>
        /// fletching : 矢羽根 (100F, 50G)
        /// <para>
        /// <see cref="fletching"/>
        /// ->
        /// <see cref="bodkin_arrow"/>
        /// ->
        /// <see cref="bracer"/>
        /// </para>
        /// </summary>
        fletching = 199,

        /// <summary>
        /// bodkin arrow : 錐状矢じり (200F, 100G)
        /// <para>
        /// <see cref="fletching"/>
        /// ->
        /// <see cref="bodkin_arrow"/>
        /// ->
        /// <see cref="bracer"/>
        /// </para>
        /// </summary>
        bodkin_arrow = 200,

        /// <summary>
        /// bracer : 小手 (300F, 200G)
        /// <para>
        /// <see cref="fletching"/>
        /// ->
        /// <see cref="bodkin_arrow"/>
        /// ->
        /// <see cref="bracer"/>
        /// </para>
        /// </summary>
        bracer = 201,

        /// <summary>
        /// forging : 鍛造 (150F)
        /// <para>
        /// <see cref="forging"/>
        /// ->
        /// <see cref="iron_casting"/>
        /// ->
        /// <see cref="blast_furnace"/>
        /// </para>
        /// </summary>
        forging = 67,

        /// <summary>
        /// iron casting : 鋳造 (220F, 120G)
        /// <para>
        /// <see cref="forging"/>
        /// ->
        /// <see cref="iron_casting"/>
        /// ->
        /// <see cref="blast_furnace"/>
        /// </para>
        /// </summary>
        iron_casting = 68,

        /// <summary>
        /// blast furnace : 高温溶鉱炉 (275F, 225G)
        /// <para>
        /// <see cref="forging"/>
        /// ->
        /// <see cref="iron_casting"/>
        /// ->
        /// <see cref="blast_furnace"/>
        /// </para>
        /// </summary>
        blast_furnace = 75,

        /// <summary>
        /// scale barding : 騎馬用うろこの鎧 (150F)
        /// <para>
        /// <see cref="scale_barding"/>
        /// ->
        /// <see cref="chain_barding"/>
        /// ->
        /// <see cref="plate_barding"/>
        /// </para>
        /// </summary>
        scale_barding = 81,

        /// <summary>
        /// chain barding : 騎馬用鎖かたびら (250F, 150G)
        /// <para>
        /// <see cref="scale_barding"/>
        /// ->
        /// <see cref="chain_barding"/>
        /// ->
        /// <see cref="plate_barding"/>
        /// </para>
        /// </summary>
        chain_barding = 82,

        /// <summary>
        /// plate barding : 騎馬用甲冑 (350F, 200G)
        /// <para>
        /// <see cref="scale_barding"/>
        /// ->
        /// <see cref="chain_barding"/>
        /// ->
        /// <see cref="plate_barding"/>
        /// </para>
        /// </summary>
        plate_barding = 80,

        /// <summary>
        /// scale mail : 歩兵用うろこの鎧 (100F)
        /// <para>
        /// <see cref="scale_mail"/>
        /// ->
        /// <see cref="chain_mail"/>
        /// ->
        /// <see cref="plate_mail"/>
        /// </para>
        /// </summary>
        scale_mail = 74,

        /// <summary>
        /// chain mail : 歩兵用鎖かたびら (200F, 100G)
        /// <para>
        /// <see cref="scale_mail"/>
        /// ->
        /// <see cref="chain_mail"/>
        /// ->
        /// <see cref="plate_mail"/>
        /// </para>
        /// </summary>
        chain_mail = 76,

        /// <summary>
        /// plate mail : 歩兵用甲冑 (300F, 150G)
        /// <para>
        /// <see cref="scale_mail"/>
        /// ->
        /// <see cref="chain_mail"/>
        /// ->
        /// <see cref="plate_mail"/>
        /// </para>
        /// </summary>
        plate_mail = 77,

        /// <summary>
        /// masonry : 石工技術 (150F, 175W)
        /// </summary>
        masonry = 50,

        /// <summary>
        /// fortified wall : 強化壁
        /// </summary>
        fortified_wall = 194,

        /// <summary>
        /// ballistics : 弾道学 (300W, 175G)
        /// </summary>
        ballistics = 93,

        /// <summary>
        /// heated shot : 火砲学 (350F, 100G)
        /// </summary>
        heated_shot = 380,

        /// <summary>
        /// murder holes : 迎撃用窓 (200F, 100S)
        /// </summary>
        murder_holes = 322,

        /// <summary>
        /// stonecutting : 人力起重機 (300F, 200W)
        /// </summary>
        stonecutting = 54,

        /// <summary>
        /// architecture : 建築学 (300F, 200W)
        /// </summary>
        architecture = 51,

        /// <summary>
        /// chemistry : 化学 (300F, 200G)
        /// </summary>
        chemistry = 47,

        /// <summary>
        /// siege engineers : 包囲攻撃技術 (500F, 600W)
        /// </summary>
        siege_engineers = 377,

        /// <summary>
        /// guard tower : 監視塔 (100F, 250W)
        /// </summary>
        guard_tower = 140,

        /// <summary>
        /// keep : 防御塔 (500F, 350W)
        /// </summary>
        keep = 63,

        /// <summary>
        /// bombard tower : 砲台 (800F, 400W)
        /// </summary>
        bombard_tower = 64,

        /// <summary>
        /// man at arms : 軍兵 (100F, 40G)
        /// <para>
        /// <see cref="man_at_arms"/>
        /// ->
        /// <see cref="long_swordsman"/>
        /// ->
        /// <see cref="two_handed_swordsman"/>
        /// ->
        /// <see cref="champion"/>
        /// </para>
        /// </summary>
        man_at_arms = 222,

        /// <summary>
        /// long swordsman : 長剣剣士 (200F, 65G)
        /// <para>
        /// <see cref="man_at_arms"/>
        /// ->
        /// <see cref="long_swordsman"/>
        /// ->
        /// <see cref="two_handed_swordsman"/>
        /// ->
        /// <see cref="champion"/>
        /// </para>
        /// </summary>
        long_swordsman = 207,

        /// <summary>
        /// two handed swordsman : 重剣剣士 (300F, 100G)
        /// <para>
        /// <see cref="man_at_arms"/>
        /// ->
        /// <see cref="long_swordsman"/>
        /// ->
        /// <see cref="two_handed_swordsman"/>
        /// ->
        /// <see cref="champion"/>
        /// </para>
        /// </summary>
        two_handed_swordsman = 217,

        /// <summary>
        /// champion : 近衛剣士 (750F, 350G)
        /// <para>
        /// <see cref="man_at_arms"/>
        /// ->
        /// <see cref="long_swordsman"/>
        /// ->
        /// <see cref="two_handed_swordsman"/>
        /// ->
        /// <see cref="champion"/>
        /// </para>
        /// </summary>
        champion = 264,

        /// <summary>
        /// pikeman : 長槍兵 (215F, 90G)
        /// <para>
        /// <see cref="pikeman"/>
        /// ->
        /// <see cref="halberdier"/>
        /// </para>
        /// </summary>
        pikeman = 197,

        /// <summary>
        /// halberdier : 矛槍兵 (300F, 600G)
        /// <para>
        /// <see cref="pikeman"/>
        /// ->
        /// <see cref="halberdier"/>
        /// </para>
        /// </summary>
        halberdier = 429,

        /// <summary>
        /// elite_eagle_warrior : エリートイーグルウォリア (800F, 500G)
        /// </summary>
        elite_eagle_warrior = 434,

        /// <summary>
        /// tracking : 追跡術 (50F)
        /// </summary>
        tracking = 90,

        /// <summary>
        /// squires : 武者修行 (100F)
        /// </summary>
        squires = 215,

        /// <summary>
        /// crossbow : 石弓射手 (125F, 75G)
        /// </summary>
        crossbow = 100,

        /// <summary>
        /// arbalest : 重石弓射手 (350F, 300G)
        /// </summary>
        arbalest = 237,

        /// <summary>
        /// elite skirmisher : 精鋭散兵 (200W, 100G)
        /// </summary>
        elite_skirmisher = 98,

        /// <summary>
        /// heavy cavalry archer : 重弓騎兵 (900F, 500G)
        /// </summary>
        heavy_cavalry_archer = 218,

        /// <summary>
        /// thumb ring : 弓懸 (300F, 250W)
        /// </summary>
        thumb_ring = 437,

        /// <summary>
        /// parthian tactics : パルティアン戦術 (200F, 250G)
        /// </summary>
        parthian_tactics = 436,

        /// <summary>
        /// light cavalry : 騎兵 (150F, 50G)
        /// </summary>
        light_cavalry = 254,

        /// <summary>
        /// hussar : ハサー (500F, 600G)
        /// </summary>
        hussar = 428,

        /// <summary>
        /// cavalier : 重騎士 (300F, 300G)
        /// </summary>
        cavalier = 209,

        /// <summary>
        /// paladin : 近衛騎士 (1300F, 750G)
        /// </summary>
        paladin = 265,

        /// <summary>
        /// heavy camel : 重装らくだ騎兵 (325F, 360G)
        /// </summary>
        heavy_camel = 236,

        /// <summary>
        /// bloodlines : 血統 (150F, 100G)
        /// </summary>
        bloodlines = 435,

        /// <summary>
        /// husbandry : 繁殖 (150F)
        /// </summary>
        husbandry = 39,

        /// <summary>
        /// onager : 改良型投石機 (800F, 500G)
        /// </summary>
        onager = 257,

        /// <summary>
        /// siege onager : 破城投石機 (1450F, 1000G)
        /// </summary>
        siege_onager = 320,

        /// <summary>
        /// capped ram : 強化破城槌 (300F)
        /// </summary>
        capped_ram = 96,

        /// <summary>
        /// siege ram : 改良強化破城槌 (1000F)
        /// </summary>
        siege_ram = 255,

        /// <summary>
        /// heavy scorpion : ヘビースコーピオン (1000F, 1000W)
        /// </summary>
        heavy_scorpion = 239,

        /// <summary>
        /// redemption : 贖い (475G)
        /// </summary>
        redemption = 316,

        /// <summary>
        /// fervor : 篤信 (140G)
        /// </summary>
        fervor = 252,

        /// <summary>
        /// sanctity : 神聖 (120G)
        /// </summary>
        sanctity = 231,

        /// <summary>
        /// atonement : 償い (325G)
        /// </summary>
        atonement = 319,

        /// <summary>
        /// heresy : 異端 (1000G)
        /// </summary>
        heresy = 439,

        /// <summary>
        /// block printing : 活版印刷 (200G)
        /// </summary>
        block_printing = 230,

        /// <summary>
        /// illumination : 啓蒙 (120G)
        /// </summary>
        illumination = 233,

        /// <summary>
        /// faith : 信仰 (750F, 1000G)
        /// </summary>
        faith = 45,

        /// <summary>
        /// theocracy : 神政 (200G)
        /// </summary>
        theocracy = 438,

        /// <summary>
        /// war galley : 大型ガレー船 (230F, 100G)
        /// </summary>
        war_galley = 34,

        /// <summary>
        /// galleon : ガリオン船 (400F, 315W)
        /// </summary>
        galleon = 35,

        /// <summary>
        /// fast fire ship : 高速火炎船 (280W, 250G)
        /// </summary>
        fast_fire_ship = 246,

        /// <summary>
        /// heavy demolition ship : 重爆破工作船 (200W, 300G)
        /// </summary>
        heavy_demolition_ship = 244,

        /// <summary>
        /// cannon galleon : キャノンガリオン船 (400F, 500W)
        /// </summary>
        cannon_galleon = 37,

        /// <summary>
        /// deck guns : 機動キャノンガリオン船 (525W, 500G)
        /// </summary>
        deck_guns = 376,

        /// <summary>
        /// shipwright 造船技術 (1000F, 300G)
        /// </summary>
        shipwright = 373,

        /// <summary>
        /// careening : 傾船技術 (250F, 150G)
        /// </summary>
        careening = 374,

        /// <summary>
        /// dry dock : 乾ドック (600F, 400G)
        /// </summary>
        dry_dock = 375,

        /// <summary>
        /// hoardings : 城壁強化 (400F, 400W)
        /// </summary>
        hoardings = 379,

        /// <summary>
        /// sappers : 土木技術 (400F, 200G)
        /// </summary>
        sappers = 321,

        /// <summary>
        /// conscription : 徴用 (150F, 150G)
        /// </summary>
        conscription = 315,

        /// <summary>
        /// elite jaguar man : エリートジャガーウォリア
        /// </summary>
        elite_jaguar_man = 432,

        /// <summary>
        /// elite cataphract : エリートカタフラクト
        /// </summary>
        elite_cataphract = 361,

        /// <summary>
        /// elite woad raider : エリートウォードレイダー
        /// </summary>
        elite_woad_raider = 370,

        /// <summary>
        /// elite chu ko nu : 改良型連弩兵
        /// </summary>
        elite_chu_ko_nu = 362,

        /// <summary>
        /// elite longbowman : エリートロングボウ
        /// </summary>
        elite_longbowman = 360,

        /// <summary>
        /// elite throwing axeman : エリートフランカスロウ
        /// </summary>
        elite_throwing_axeman = 363,

        /// <summary>
        /// elite huskarl : エリートハスカール
        /// </summary>
        elite_huskarl = 365,

        /// <summary>
        /// elite tarkan : エリートタルカン
        /// </summary>
        elite_tarkan = 2,

        /// <summary>
        /// elite samurai : 剣豪
        /// </summary>
        elite_samurai = 366,

        /// <summary>
        /// elite war wagon : 強化戦車
        /// </summary>
        elite_war_wagon = 450,

        /// <summary>
        /// elite turtle ship : 重装亀甲船
        /// </summary>
        elite_turtle_ship = 348,

        /// <summary>
        /// elite plumed archer : 精鋭羽飾射手
        /// </summary>
        elite_plumed_archer = 27,

        /// <summary>
        /// elite mangudai : エリートマングダイ
        /// </summary>
        elite_mangudai = 371,

        /// <summary>
        /// elite war elephant : エリートエレファント
        /// </summary>
        elite_war_elephant = 367,

        /// <summary>
        /// elite mameluke : エリートマムルーク
        /// </summary>
        elite_mameluke = 378,

        /// <summary>
        /// elite conquistador : エリートコンキスタドール
        /// </summary>
        elite_conquistador = 60,

        /// <summary>
        /// elite teutonic knight : エリートチュートンナイト
        /// </summary>
        elite_teutonic_knight = 364,

        /// <summary>
        /// elite janissary : エリートイュニチェリ
        /// </summary>
        elite_janissary = 369,

        /// <summary>
        /// elite berserk : エリートベルセルク
        /// </summary>
        elite_berserk = 398,

        /// <summary>
        /// elite longboat : 重装バイキング船
        /// </summary>
        elite_longboat = 372,

        // The following parameters are not defined by the system,
        // so define by defconst.

        /// <summary>
        /// Herbal medicine : 薬草学 (350G)
        /// </summary>
        HerbalMedicine = 441,

        /// <summary>
        /// SpiesTreason : 諜報/反逆 (villagers * 200G)
        /// </summary>
        SpiesTreason = 408,

        /// <summary>
        /// GarlandWars : 栄誉戦
        /// </summary>
        GarlandWars = 24,

        /// <summary>
        /// Logistica : 兵站学
        /// </summary>
        Logistica = 61,

        /// <summary>
        /// FurorCeltica : ケルトの怒り
        /// </summary>
        FurorCeltica = 5,

        /// <summary>
        /// Rocketry : 砲弾術
        /// </summary>
        Rocketry = 52,

        /// <summary>
        /// Yeomen : ヨーマン
        /// </summary>
        Yeomen = 3,

        /// <summary>
        /// BeardedAxe : ビアードアックス
        /// </summary>
        BeardedAxe = 83,

        /// <summary>
        /// Anarchy : 無秩序
        /// </summary>
        Anarchy = 16,

        /// <summary>
        /// Perfusion : パーフュージョン
        /// </summary>
        Perfusion = 457,

        /// <summary>
        /// Atheism : 無神論
        /// </summary>
        Atheism = 21,

        /// <summary>
        /// Kataparuto : 投擲術
        /// </summary>
        Kataparuto = 59,

        /// <summary>
        /// Shinkichon : 新機箭
        /// </summary>
        Shinkichon = 445,

        /// <summary>
        /// ElDorado : エルドラド
        /// </summary>
        ElDorado = 4,

        /// <summary>
        /// Drill : 演習
        /// </summary>
        Drill = 6,

        /// <summary>
        /// Mahouts : 象使い
        /// </summary>
        Mahouts = 7,

        /// <summary>
        /// Zealotry : 狂信
        /// </summary>
        Zealotry = 9,

        /// <summary>
        /// Supremacy : 覇権
        /// </summary>
        Supremacy = 440,

        /// <summary>
        /// Crenellations : 銃眼付胸壁
        /// </summary>
        Crenellations = 11,

        /// <summary>
        /// Artillery : 砲術
        /// </summary>
        Artillery = 10,

        /// <summary>
        /// Berserkergang : ベルセルクギャング
        /// </summary>
        Berserkergang = 49,

        // SystemDefinedConstants /////////////////////////////////////////////

        /// <summary>
        /// my unique unit upgrade : エリートユニークユニット
        /// </summary>
        my_unique_unit_upgrade = 0x0FFFFFFE,

        /// <summary>
        /// my research : ユニークテクノロジー
        /// </summary>
        my_unique_research = 0x0FFFFFFF,

        /// <summary>
        /// Unknown : 未定義
        /// </summary>
        Unknown = 0x7FFFFFFF,
    }
}
