namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;
    using static LibAoe2AISharp.Framework.BoarHuntingCommandCollection;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// Boar is far from drop site.
    /// </summary>
    public class BoarFar : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoarFar"/> class.
        /// <para>
        /// <see cref="BoarState"/> is changed from <see cref="Eating"/> to <see cref="Finish"/>.
        /// </para>
        /// </summary>
        /// <param name="maxLureDistance">max lure distance.</param>
        public BoarFar(short maxLureDistance)
        {
            Comment = "Boar is far. Then stop hunting.";
            Facts.Add(
               new goal(BoarState, Eating),
               new dropsite_min_distance(resource_type.live_boar, relop.ge, maxLureDistance));
            Actions.Add(
                new set_goal(BoarState, Finish),
                new set_strategic_number(sn.enable_boar_hunting, 1),
                new set_strategic_number(sn.minimum_number_hunters, 0));
        }
    }
}
