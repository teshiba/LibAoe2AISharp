using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Complex condition of AIFact.
    /// </summary>
    public static class ComplexConditions
    {
        /// <summary>
        /// Gets whether AnyAlly has Market.
        /// </summary>
        /// <returns>condition.</returns>
        public static Conditions AnyAllyHasMarket()
        {
            var ret = new player_in_game(player_number.any_ally)
                    & new players_building_type_count(
                        player_number.any_ally, building.market, relop.ge, 1);
            ret.Comment = "Any ally has market";
            return ret;
        }

        /// <summary>
        /// Gets whether Shepherd exist.
        /// </summary>
        /// <returns>condition.</returns>
        public static Conditions ShepherdExist()
        {
            var ret = new unit_type_count_total(unit.ShepherdMan, relop.ge, 1)
                    | new unit_type_count_total(unit.ShepherdWoman, relop.ge, 1);
            ret.Comment = "Shepherd exist";
            return ret;
        }

        /// <summary>
        /// Gets whether Hunter exist.
        /// </summary>
        /// <returns>condition.</returns>
        public static Conditions HunterExist()
        {
            var ret = new unit_type_count_total(unit.HunterMan, relop.ge, 1)
                    | new unit_type_count_total(unit.HunterWoman, relop.ge, 1);
            ret.Comment = "Hunter exist";
            return ret;
        }

        /// <summary>
        /// Gets whether Fisher exist.
        /// </summary>
        /// <returns>condition.</returns>
        public static Conditions FisherExist()
        {
            var ret = new unit_type_count_total(unit.FisherMan, relop.ge, 1)
                    | new unit_type_count_total(unit.FisherWoman, relop.ge, 1);
            ret.Comment = "Fisher exist";
            return ret;
        }

        /// <summary>
        /// Gets whether Harvester exist.
        /// </summary>
        /// <returns>condition.</returns>
        public static Conditions HarvesterExist()
        {
            var ret = new unit_type_count_total(unit.HarvesterMan, relop.ge, 1)
                    | new unit_type_count_total(unit.HarvesterWoman, relop.ge, 1);
            ret.Comment = "Harvester exist";
            return ret;
        }

        /// <summary>
        /// Gets whether Miner exist.
        /// </summary>
        /// <returns>condition.</returns>
        public static Conditions MinerExist()
        {
            var stoneMiner = new unit_type_count_total(unit.StoneMinerMan, relop.ge, 1)
                           | new unit_type_count_total(unit.StoneMinerWoman, relop.ge, 1);

            var goldMiner = new unit_type_count_total(unit.GoldMinerMan, relop.ge, 1)
                          | new unit_type_count_total(unit.GoldMinerWoman, relop.ge, 1);

            var ret = goldMiner | stoneMiner;

            ret.Comment = "Miner exist";
            return ret;
        }

        /// <summary>
        /// Gets whether Farmer exist.
        /// </summary>
        /// <returns>condition.</returns>
        public static Conditions FarmerExist()
        {
            var ret = new unit_type_count_total(unit.FarmerMan, relop.ge, 1)
                    | new unit_type_count_total(unit.FarmerWoman, relop.ge, 1);
            ret.Comment = "Farmer exist";
            return ret;
        }

        /// <summary>
        /// Gets whether Lumberjack exist.
        /// </summary>
        /// <returns>condition.</returns>
        public static Conditions LumberjackExist()
        {
            var ret = new unit_type_count_total(unit.LumberjackMan, relop.ge, 1)
                    | new unit_type_count_total(unit.LumberjackWonam, relop.ge, 1);
            ret.Comment = "Lumberjack exist";
            return ret;
        }
    }
}
