namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;
    using static LibAoe2AISharp.Framework.BoarHuntingCommandCollection;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// Rule after finish eating a boar.
    /// </summary>
    public class BoarReHunting : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoarReHunting"/> class.
        /// <para>
        /// <see cref="BoarState"/> is changed from <see cref="Eating"/> to <see cref="Luring"/>.
        /// </para>
        /// </summary>
        /// <param name="eatDistance">eat distance.</param>
        /// <param name="lureDistance">lure distance.</param>
        public BoarReHunting(short eatDistance, short lureDistance)
        {
            Comment = "Boar is exsist";

            Facts.Add(
               new goal(BoarState, Eating),
               !new dropsite_min_distance(resource_type.live_boar, relop.le, eatDistance),
               new dropsite_min_distance(resource_type.live_boar, relop.ge, eatDistance));

            Actions.Add(
               new set_strategic_number(sn.maximum_hunt_drop_distance, lureDistance),
               new set_goal(BoarState, Luring));
        }
    }
}
