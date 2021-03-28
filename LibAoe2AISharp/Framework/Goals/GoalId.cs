namespace LibAoe2AISharp.Framework
{
    using System;
    using System.Collections.ObjectModel;
    using LibAoe2AISharp.Specifications;

    /// <summary>
    /// manage goal-id name using defconst.
    /// </summary>
    public class GoalId : defconst
    {
        private static readonly Collection<GoalId> SelfList = new ();

        private static int count;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalId"/> class.
        /// </summary>
        /// <param name="constantName">constant-name.</param>
        /// <param name="comment">comment of goalId.</param>
        public GoalId(string constantName, string comment)
        {
            if (count + 1 > Limit.GoalIdMax) {
                throw new OverflowException($"The number of GoadID is over the max {Limit.GoalIdMax}.");
            }

            count++;

            ConstantName = constantName;
            Comment = "goal-id[" + count + "] " + comment;
            Value = count;
            SelfList.Add(this);
        }

        /// <inheritdoc/>
        public override string ToScript(int indentLevel)
        {
            return base.ToScript(indentLevel);
        }
    }
}