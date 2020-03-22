using System;
using System.Collections.ObjectModel;
using LibAoe2AISharp.Specifications;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// manage goal-id name using defconst.
    /// </summary>
    public class GoalId : defconst
    {
        private static readonly Collection<GoalId> SelfList = new Collection<GoalId>();

        private static int count = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalId"/> class.
        /// </summary>
        /// <param name="constantName">constant-name.</param>
        /// <param name="comment">comment of goalId.</param>
        public GoalId(string constantName, string comment)
        {
            if (count + 1 > Limit.GoalIdMax) {
                throw new IndexOutOfRangeException();
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