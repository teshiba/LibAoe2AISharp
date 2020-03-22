using LibAoe2AISharp.Utilty;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks the computer player's food amount.
    /// </summary>
    public class food_amount : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="food_amount"/> class.
        /// </summary>
        /// <param name="ope">Relational operator.</param>
        /// <param name="value">evaluation value.</param>
        public food_amount(relop ope, int value)
            : base(ope, value)
        {
            Comment = GetType().Name.ToLocalLang();
        }
    }
}