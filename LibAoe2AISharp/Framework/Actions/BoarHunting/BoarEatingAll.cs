namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;
    using static LibAoe2AISharp.Framework.BoarHuntingCommandCollection;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// After eating all boar.
    /// </summary>
    public class BoarEatingAll : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoarEatingAll"/> class.
        /// </summary>
        /// <param name="maxLureDistance">max lure distance.</param>
        public BoarEatingAll(short maxLureDistance)
        {
            Comment = "Boar nothing";
            Facts.Add(
                new goal(BoarState, Eating),
                !new dropsite_min_distance(resource_type.live_boar, relop.le, maxLureDistance),
                new unit_type_count(unit.villager_hunter, relop.eq, 0));

            Actions.Add(
                new set_goal(BoarState, Finish),
                new set_strategic_number(sn.enable_boar_hunting, 1),
                new set_strategic_number(sn.minimum_number_hunters, 0));
        }
    }
}
