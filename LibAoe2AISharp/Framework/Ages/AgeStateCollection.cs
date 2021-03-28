namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;

    /// <summary>
    /// goal-id definitions.
    /// </summary>
    public class AgeStateCollection : DefconstCollection
    {
        /// <summary>
        /// Transition state.
        /// </summary>
        public static readonly GoalId AgeState = new ("AgeState", "Age transit state");

        /// <summary>
        /// Age is transitioned.
        /// </summary>
        public static readonly Age Transitioned = new ("Transitioned", "Age is transitioned");

        /// <summary>
        /// Age is transitioning.
        /// </summary>
        public static readonly Age Transitioning = new ("Transitioning", "Age is transitioning");
    }
}
