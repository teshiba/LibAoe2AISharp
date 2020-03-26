using LibAoe2AISharp.Specifications;
using LibAoe2AISharp.Utilty;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Basic control of research action.
    /// Confirm that the unit can be researching and research.
    /// </summary>
    public class Research : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Research"/> class.
        /// </summary>
        /// <param name="researchAge">research age.</param>
        public Research(age researchAge)
        {
            Comment = "Research " + researchAge.ToLocalLang();
            Facts.Add(new can_research(researchAge));
            Actions.Add(new research(researchAge));
            ResearchAge = researchAge;
            ResearchItem = ri.Unknown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Research"/> class.
        /// </summary>
        /// <param name="researchItem">research technology.</param>
        public Research(ri researchItem)
        {
            Comment = "Research " + researchItem.ToLocalLang();
            Facts.Add(new can_research(researchItem));
            Actions.Add(new research(researchItem));
            ResearchItem = researchItem;
            ResearchAge = age.Unknown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Research"/> class.
        /// <para>
        /// Research item if the given unit is greater than or equal to the given count.
        /// </para>
        /// </summary>
        /// <param name="researchItem">research item.</param>
        /// <param name="unit">unit.</param>
        /// <param name="count">unit count.</param>
        public Research(ri researchItem, unit unit, short count)
        {
            Comment = "Research " + researchItem.ToLocalLang() + " :"
                    + unit.ToLocalLang() + " up to " + count;

            Facts.Add(
                new can_research(researchItem),
                new unit_type_count_total(unit, relop.ge, count));

            Actions.Add(new research(researchItem));
            ResearchItem = researchItem;
            ResearchAge = age.Unknown;
        }

        /// <summary>
        /// Gets research technology.
        /// </summary>
        public ri ResearchItem { get; } = ri.Unknown;

        /// <summary>
        /// Gets research age.
        /// </summary>
        public age ResearchAge { get; } = age.Unknown;
    }
}
