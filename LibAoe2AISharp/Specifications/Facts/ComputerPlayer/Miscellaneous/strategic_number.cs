using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks a strategic number's value.
    /// </summary>
    public class strategic_number : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="strategic_number"/> class.
        /// </summary>
        /// <param name="strategicNumber">strategic number.</param>
        /// <param name="ope">relational operator.</param>
        /// <param name="value">evalution value.</param>
        public strategic_number(sn strategicNumber, relop ope, int value)
            : base("sn-" + strategicNumber.ToString(), ope, value)
        {
        }
    }
}