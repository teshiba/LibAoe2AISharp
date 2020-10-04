using LibAoe2AISharp.Specifications;

using static LibAoe2AISharp.Framework.BoarHuntingCommandCollection;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Find a first boar.
    /// </summary>
    public class BoarFindFirst : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoarFindFirst"/> class.
        /// <para>
        /// <see cref="BoarState"/> is changed from <see cref="Init"/> to <see cref="Luring"/>.
        /// </para>
        /// </summary>
        /// <param name="startVillagerCount">start villager count.</param>
        /// <param name="maxLureDistance">max lure distance.</param>
        public BoarFindFirst(short startVillagerCount, short maxLureDistance)
        {
            Comment = "Boar : start hunting";
            Facts.Add(
                new goal(BoarState, Init),
                new dropsite_min_distance(resource_type.live_boar, relop.le, maxLureDistance),
                new unit_type_count_total(unit.villager, relop.gt, startVillagerCount));

            Actions.Add(
            new set_strategic_number(sn.enable_boar_hunting, 2),
            new set_strategic_number(sn.minimum_boar_lure_group_size, 1),
            new set_strategic_number(sn.maximum_hunt_drop_distance, maxLureDistance),
            new set_strategic_number(sn.minimum_number_hunters, 1),
            new set_goal(BoarState, Luring));
        }
    }
}
