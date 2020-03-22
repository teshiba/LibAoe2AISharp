namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This action sets a given goal to a given value.
    /// </summary>
    public class set_goal : AIAction
    {
        private readonly int goalId;
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="set_goal"/> class.
        /// </summary>
        /// <param name="goalId">goal-id.</param>
        /// <param name="value">goal value.</param>
        public set_goal(int goalId, int value)
        {
            this.goalId = goalId;
            this.value = value;
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(goalId, value);
        }
    }
}