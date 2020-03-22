using LibAoe2AISharp.Specifications;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// This action sets a given goal to a given value using defconst defined value.
    /// </summary>
    public class set_goal : AIAction
    {
        private readonly GoalId goalId;
        private readonly GoalValue goalValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="set_goal"/> class.
        /// </summary>
        /// <param name="goalId">goal-id.</param>
        /// <param name="goalValue">value.</param>
        public set_goal(GoalId goalId, GoalValue goalValue)
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