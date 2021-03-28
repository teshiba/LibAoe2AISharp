namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;
    using static LibAoe2AISharp.Framework.AgeStateCollection;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// Basic control reserching the age.
    /// </summary>
    public class ResearchAge : Research
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchAge"/> class.
        /// <para>
        /// Set <see cref="AgeState" /> goal to <see cref="Transitioning"/>.
        /// </para>
        /// </summary>
        /// <param name="researchAge">research age.</param>
        public ResearchAge(age researchAge)
            : base(researchAge)
        {
            if (researchAge < age.feudal_age) {
                throw new System.ArgumentOutOfRangeException(nameof(researchAge));
            }

            Facts.Add(new current_age(relop.eq, researchAge - 1));
            Actions.Add(new set_goal(AgeState, Transitioning));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchAge"/> class.
        /// <para>
        /// Set <see cref="AgeState" /> goal to <see cref="Transitioning"/>.
        /// </para>
        /// </summary>
        /// <param name="researchAge">research age.</param>
        /// <param name="population">Population required for research age.</param>
        public ResearchAge(age researchAge, int population)
            : this(researchAge)
        {
            Facts.Add(new unit_type_count(unit.villager, relop.ge, population));
        }
    }
}