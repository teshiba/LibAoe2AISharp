using LibAoe2AISharp.Specifications;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// goal-id definitions.
    /// </summary>
    public class AgeStateCollection : DefconstCollection
    {
        /// <summary>
        /// Transition state.
        /// </summary>
        public static readonly GoalId AgeState = new GoalId("AgeState", "Age transit state");

        /// <summary>
        /// Age is transitioned.
        /// </summary>
        public static readonly Age Transitioned = new Age("Transitioned", "Age is transitioned");

        /// <summary>
        /// Age is transitioning.
        /// </summary>
        public static readonly Age Transitioning = new Age("Transitioning", "Age is transitioning");
    }
}
