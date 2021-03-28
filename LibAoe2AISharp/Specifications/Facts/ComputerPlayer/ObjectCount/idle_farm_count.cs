namespace LibAoe2AISharp.Specifications
{
    using LibAoe2AISharp.Utilty;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// This fact checks a computer player's idle farm count.
    /// (Idle farm count is the number of farms with no farmers).
    /// </summary>
    public class idle_farm_count : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="idle_farm_count"/> class.
        /// </summary>
        /// <param name="ope">Relational operator.</param>
        /// <param name="value">evaluation value.</param>
        public idle_farm_count(relop ope, int value)
            : base(ope, value)
        {
            Comment = "Idle farm count " + ope.ToLocalLang() + " " + value;
        }
    }
}