using LibAoe2AISharp.Utilty;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks the computer player's total unit count.
    /// (include trained and queued units).
    /// <para>
    /// See also <seealso cref="unit_type_count"/>.
    /// </para>
    /// </summary>
    public class unit_type_count_total : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="unit_type_count_total"/> class.
        /// </summary>
        /// <param name="unit">Unit.</param>
        /// <param name="ope">Relational operator.</param>
        /// <param name="value">evaluation value.(Including units in training).</param>
        public unit_type_count_total(unit unit, relop ope, int value)
            : base(unit, ope, value)
        {
            Comment = "Check count : unit " + unit.ToLocalLang();
        }
    }
}
