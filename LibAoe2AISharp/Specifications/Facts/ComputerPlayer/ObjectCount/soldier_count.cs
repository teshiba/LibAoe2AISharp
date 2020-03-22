using LibAoe2AISharp.Utilty;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks the computer player's soldier count.
    /// An attack soldier is a land-based military unit.
    /// </summary>
    public class soldier_count : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="soldier_count"/> class.
        /// </summary>
        /// <param name="ope">relational operator.</param>
        /// <param name="value">soldier count.</param>
        public soldier_count(relop ope, short value)
            : base(ope, value)
        {
            Comment = "soldier count " + ope.ToLocalLang() + " " + value;
        }
    }
}
