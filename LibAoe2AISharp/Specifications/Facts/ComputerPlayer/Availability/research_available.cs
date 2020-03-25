using System;
using LibAoe2AISharp.Utilty;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// The fact checks that the given research is available to the computer player's civ, and
    /// that the research is available at this time (tech tree prerequisites are met).
    /// The fact does not check that there are enough resources to start researching.
    /// </summary>
    public class research_available : AIFact
    {
        private readonly Enum researchItem;
        private readonly bool isResearchItemEnum = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="research_available"/> class.
        /// </summary>
        /// <param name="researchItem">research item.</param>
        public research_available(ri researchItem)
            : this((Enum)researchItem)
        {
            this.researchItem = researchItem;
            isResearchItemEnum = researchItem.IsResearchItemEnum();
            Comment = researchItem.ToLocalLang();
            Comment += " is available.";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="research_available"/> class.
        /// </summary>
        /// <param name="researchAge">research age.</param>
        public research_available(age researchAge)
            : this((Enum)researchAge)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="research_available"/> class.
        /// </summary>
        /// <param name="researchItem">Research item.</param>
        public research_available(Enum researchItem)
        {
            this.researchItem = researchItem;
            Comment = researchItem.ToLocalLang() + " is available.";
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            var riPrefix = string.Empty;

            if (isResearchItemEnum) {
                riPrefix = "ri-";
            }

            return ToScript(riPrefix + researchItem.ToString());
        }
    }
}
