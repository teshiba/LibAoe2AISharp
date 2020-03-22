using LibAoe2AISharp.Utilty;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks computer player's current age.
    /// </summary>
    public class current_age : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="current_age"/> class.
        /// </summary>
        /// <param name="ope">Relational operator.</param>
        /// <param name="age">Age.</param>
        public current_age(relop ope, age age)
            : base(ope, age)
        {
            Comment = "Check " + age.ToLocalLang();
        }
    }
}