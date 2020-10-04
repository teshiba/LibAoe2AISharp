using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Framework.BoarHuntingCommandCollection;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// After lure a boar.
    /// </summary>
    public class BoarLure : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoarLure"/> class.
        /// </summary>
        /// <para>
        /// <see cref="BoarState"/> is changed from <see cref="Luring"/> to <see cref="Eating"/>.
        /// </para>
        /// <param name="eatDistance">Distance between town center and boar.</param>
        /// <param name="hunterCount">Hunter count.</param>
        public BoarLure(short eatDistance, short hunterCount)
        {
            Comment = "BoarLure::distance:" + eatDistance + ", Hunter：" + hunterCount;
            Facts.Add(
               new goal(BoarState, Luring),
               new unit_type_count(unit.villager_hunter, relop.gt, 0),
               new dropsite_min_distance(resource_type.live_boar, relop.le, eatDistance));

            // Prevent villagers from hunting other boars.
            Actions.Add(
                new set_strategic_number(sn.maximum_hunt_drop_distance, eatDistance),
                new set_strategic_number(sn.minimum_number_hunters, hunterCount),
                new set_goal(BoarState, Eating));
        }
    }
}
