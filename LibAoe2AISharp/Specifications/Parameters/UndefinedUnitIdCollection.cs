using System.Diagnostics.CodeAnalysis;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Define system undefined unit IDs.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1629:Documentation text should end with a period", Justification = "<list>")]
    public class UndefinedUnitIdCollection : DefconstCollection
    {
        /// <summary>
        /// ShepherdMan : 羊を狩る人(男)
        /// </summary>
        public static readonly defconst ShepherdMan = new defconst(592);

        /// <summary>
        /// ShepherdWoman : 羊を狩る人(女)
        /// </summary>
        public static readonly defconst ShepherdWoman = new defconst(590);

        /// <summary>
        /// HarvesterMan : 苺を採る人(男)
        /// </summary>
        public static readonly defconst HarvesterMan = new defconst(120);

        /// <summary>
        /// HarvesterWoman : 苺を採る人(女)
        /// </summary>
        public static readonly defconst HarvesterWoman = new defconst(354);

        /// <summary>
        /// HunterMan : 狩りをする人(男)
        /// </summary>
        public static readonly defconst HunterMan = new defconst(122);

        /// <summary>
        /// HunterWoman : 狩りをする人(女)
        /// </summary>
        public static readonly defconst HunterWoman = new defconst(216);

        /// <summary>
        /// FisherMan : 漁をする人(男)
        /// </summary>
        public static readonly defconst FisherMan = new defconst(56);

        /// <summary>
        /// FisherWoman : 漁をする人(女)
        /// </summary>
        public static readonly defconst FisherWoman = new defconst(57);

        /// <summary>
        /// FarmerMan : 耕す人(男)
        /// </summary>
        public static readonly defconst FarmerMan = new defconst(214);

        /// <summary>
        /// FarmerWoman : 耕す人(女)
        /// </summary>
        public static readonly defconst FarmerWoman = new defconst(259);

        /// <summary>
        /// LumberjackMan : 木を切る人(男)
        /// </summary>
        public static readonly defconst LumberjackMan = new defconst(123);

        /// <summary>
        /// LumberjackWoman : 木を切る人(女)
        /// </summary>
        public static readonly defconst LumberjackWoman = new defconst(218);

        /// <summary>
        /// GoldMinerMan : 金を掘る人(男)
        /// </summary>
        public static readonly defconst GoldMinerMan = new defconst(579);

        /// <summary>
        /// GoldMinerWoman : 金を掘る人(女)
        /// </summary>
        public static readonly defconst GoldMinerWoman = new defconst(581);

        /// <summary>
        /// StoneMinerMan : 石を掘る人(男)
        /// </summary>
        public static readonly defconst StoneMinerMan = new defconst(124);

        /// <summary>
        /// StoneMinerWoman : 石を掘る人(女)
        /// </summary>
        public static readonly defconst StoneMinerWoman = new defconst(220);

        /// <summary>
        /// BuilderMan : 建築する人(男)
        /// </summary>
        public static readonly defconst BuilderMan = new defconst(118);

        /// <summary>
        /// BuilderWoman : 建築する人(女)
        /// </summary>
        public static readonly defconst BuilderWoman = new defconst(212);

        /// <summary>
        /// RepairMan : 補修する人(男)
        /// </summary>
        public static readonly defconst RepairMan = new defconst(156);

        /// <summary>
        /// RepairWoman : 補修する人(女)
        /// </summary>
        public static readonly defconst RepairWoman = new defconst(222);

        /// <summary>
        /// WaitingMan : 待機中の人(男)
        /// </summary>
        public static readonly defconst WaitingMan = new defconst(83);

        /// <summary>
        /// WaitingWoman : 待機中の人(女)
        /// </summary>
        public static readonly defconst WaitingWoman = new defconst(293);

        /// <summary>
        /// Sheep : 自分の生きている羊
        /// </summary>
        public static readonly defconst Sheep = new defconst(594);

        /// <summary>
        /// InfantryGroup : 歩兵グループ
        /// </summary>
        public static readonly defconst InfantryGroup = new defconst(906);

        /// <summary>
        /// ArcherGroup : 射手グループ
        /// </summary>
        public static readonly defconst ArcherGroup = new defconst(900);

        /// <summary>
        /// CavalryGroup : 騎兵グループ
        /// </summary>
        public static readonly defconst CavalryGroup = new defconst(912);
    }
}