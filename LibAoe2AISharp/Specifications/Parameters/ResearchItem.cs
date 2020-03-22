using System;
using System.Collections.ObjectModel;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Research item utility class.
    /// </summary>
    public static class ResearchItem
    {
        /// <summary>
        /// List of Enum.ToString which is SystemDefinedConst.
        /// For every computer player the system defines a set of constants
        /// that make rule-writing easier and more efficient.
        /// <see cref="player_number"/>,
        /// <see cref="ri"/>,
        /// <see cref="civ"/> and
        /// <see cref="unit"/>.
        /// </summary>
        private static readonly Collection<string> SystemDefinedConstCollection
            = new Collection<string>() {
            // player_number
            "my_player_number",

            // ri
            "my_unique_unit_upgrade",
            "my_unique_research",

            // civ
            "my_civ",

            // unit
            "my_unique_unit",
            "my_elite_unique_unit",
            "my_unique_unit_line",
        };

        /// <summary>
        /// Confirm whether system defined constant parameter.
        /// </summary>
        /// <param name="constantName">Constant name.</param>
        /// <returns>system defined or not.</returns>
        public static bool IsSystemDefinedConst(this Enum constantName)
        {
            return SystemDefinedConstCollection.Contains(constantName?.ToString());
        }

        /// <summary>
        ///  Returns a value indicating whether a specific research item occurs within <see cref="ri"/>,.
        /// </summary>
        /// <param name="researchItem">research item.</param>
        /// <returns>
        /// true if the research item parameter occurs within <see cref="ri"/>,
        /// or if otherwise, false.
        /// </returns>
        public static bool IsResearchItemEnum(this Enum researchItem)
        {
            bool ret;

            if (researchItem.IsSystemDefinedConst()) {
                ret = false;
            } else {
                var defconsts = new UndefinedResearchIdCollection();
                if (defconsts.Contains(researchItem.ToString())) {
                    ret = false;
                } else {
                    ret = true;
                }
            }

            return ret;
        }
    }
}
