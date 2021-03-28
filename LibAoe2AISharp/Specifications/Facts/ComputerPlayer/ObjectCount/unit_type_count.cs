namespace LibAoe2AISharp.Specifications
{
    using LibAoe2AISharp.Utilty;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// This fact checks the computer player's unit count.
    /// Only trained units of the given type are included.
    /// <para>
    /// See also <seealso cref="unit_type_count_total"/>.
    /// </para>
    /// </summary>
    public class unit_type_count : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="unit_type_count"/> class.
        /// </summary>
        /// <param name="unit">Unit.</param>
        /// <param name="ope">Relational operator.</param>
        /// <param name="value">evaluation value.(Only trained units).</param>
        public unit_type_count(unit unit, relop ope, int value)
            : base(unit, ope, value)
        {
            Comment = "Check count : unit " + unit.ToLocalLang();
        }
    }
}
