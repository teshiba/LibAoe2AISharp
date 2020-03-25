using System;
using LibAoe2AISharp.Utilty;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks if the given research can start.
    /// </summary>
    public class can_research : AIFact
    {
        private readonly Enum researchItem;
        private readonly bool isResearchItemEnum = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="can_research"/> class.
        /// </summary>
        /// <param name="researchItem">research item.</param>
        public can_research(ri researchItem)
            : this((Enum)researchItem)
        {
            isResearchItemEnum = researchItem.IsResearchItemEnum();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="can_research"/> class.
        /// </summary>
        /// <param name="researchAge">Research age.</param>
        public can_research(age researchAge)
            : this((Enum)researchAge)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="can_research"/> class.
        /// </summary>
        /// <param name="researchItem">research item.</param>
        private can_research(Enum researchItem)
        {
            this.researchItem = researchItem;
            Comment = "Can research " + researchItem.ToLocalLang() + "?";
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
