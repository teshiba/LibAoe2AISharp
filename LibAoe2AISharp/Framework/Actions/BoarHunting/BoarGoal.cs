namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// defconst for boar hunting goal.
    /// </summary>
    public class BoarGoal : GoalValue
    {
        private static int count;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoarGoal"/> class.
        /// </summary>
        /// <param name="constantName">Goal Value name.</param>
        /// <param name="comment">comment.</param>
        public BoarGoal(string constantName, string comment)
            : base("Boar" + constantName, count, "[Boar]" + comment)
        {
        }

        /// <inheritdoc/>
        protected override int Count { get => count; set => count = value; }
    }
}