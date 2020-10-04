using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Framework.AgeStateCollection;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Initialize goal ID parameters.
    /// </summary>
    public class InitGoalId : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitGoalId"/> class.
        /// </summary>
        public InitGoalId()
        {
            Comment = "Initialize goal ID parameters";
            Actions.Add(
                new set_goal(AgeState, Transitioned),
                new disable_self());
        }
    }
}