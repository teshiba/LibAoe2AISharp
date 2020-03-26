using LibAoe2AISharp.Utilty;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks the computer player's total building count.
    /// (includes queued buildings).
    /// </summary>
    public class building_type_count_total : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="building_type_count_total"/> class.
        /// </summary>
        /// <param name="building">Type of building.</param>
        /// <param name="ope">Reference operator.</param>
        /// <param name="value">Evaluation value.</param>
        public building_type_count_total(building building, relop ope, int value)
            : base(building, ope, value)
        {
            Comment = "Count of " + building.ToLocalLang();
        }
    }
}
