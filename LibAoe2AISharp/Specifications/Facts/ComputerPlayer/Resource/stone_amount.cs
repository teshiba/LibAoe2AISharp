using LibAoe2AISharp.Utilty;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks the computer player's stone amount.
    /// </summary>
    public class stone_amount : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="stone_amount"/> class.
        /// </summary>
        /// <param name="ope">Relational operator.</param>
        /// <param name="value">evaluation value.</param>
        public stone_amount(relop ope, int value)
            : base(ope, value)
        {
            Comment = GetType().Name.ToLocalLang();
        }
    }
}