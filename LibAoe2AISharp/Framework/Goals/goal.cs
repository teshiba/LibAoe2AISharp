namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;

    /// <summary>
    /// This fact checks what the given goal is.
    /// </summary>
    public class goal : AIFact
    {
        private readonly GoalId goalId;
        private readonly GoalValue goalValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="goal"/> class.
        /// </summary>
        /// <param name="goalId">goal-id.</param>
        /// <param name="goalValue">goal-dl value.</param>
        public goal(GoalId goalId, GoalValue goalValue)
        {
            this.goalId = goalId;
            this.goalValue = goalValue;
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(goalId.ConstantName, goalValue.ConstantName);
        }
    }
}