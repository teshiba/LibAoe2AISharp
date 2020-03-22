using LibAoe2AISharp.Specifications;
using LibAoe2AISharp.Utilty;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Confirm that the building can be built with "can_build" then build the building with "build".
    /// <para>(<see cref="defrule"/> (<see cref="can_build"/>(<see cref="building"/>)) => (<see cref="build"/>(<see cref="building"/>))).</para>
    /// </summary>
    public class Build : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Build"/> class.
        /// </summary>
        /// <param name="building">Type of building.</param>
        public Build(building building)
        {
            Comment = "Build " + building.ToLocalLang();
            Facts.Add(new can_build(building));
            Actions.Add(new build(building));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Build"/> class.
        /// </summary>
        /// <param name="building">Type of building.</param>
        /// <param name="count">Max number.</param>
        public Build(building building, int count)
            : this(building)
        {
            Comment += " up to " + count + ".";
            Facts.Add(new building_type_count_total(building, relop.lt, count));
        }
    }
}
