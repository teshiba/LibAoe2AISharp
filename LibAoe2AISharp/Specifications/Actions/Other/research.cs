using System;
using LibAoe2AISharp.Utilty;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This action researches the given item.
    /// </summary>
    public class research : AIAction
    {
        private readonly Enum researchItem;
        private readonly bool isResearchItemEnum = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="research"/> class.
        /// </summary>
        /// <param name="researchItem">Research item.</param>
        public research(ri researchItem)
            : this((Enum)researchItem)
        {
            isResearchItemEnum = researchItem.IsResearchItemEnum();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="research"/> class.
        /// </summary>
        /// <param name="researchAge">Research age.</param>
        public research(age researchAge)
            : this((Enum)researchAge)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="research"/> class.
        /// </summary>
        /// <param name="researchItem">Research item.</param>
        private research(Enum researchItem)
        {
            this.researchItem = researchItem;
            Comment = "Research " + researchItem.ToLocalLang();
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            var prefix = string.Empty;

            if (isResearchItemEnum) {
                prefix = "ri-";
            }

            return ToScript(prefix + researchItem.ToString());
        }
    }
}