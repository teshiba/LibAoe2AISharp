using LibAoe2AISharp.Specifications;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Define goal-id value.
    /// </summary>
    public abstract class GoalValue : defconst
    {

        private static int count = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalValue"/> class.
        /// </summary>
        /// <param name="constantName">constant-name.</param>
        /// <param name="comment">comment.</param>
        public GoalValue(string constantName, string comment)
            : base(constantName, count, comment)
        {
            Count++;

            Comment = "goal-id value[" + Count + "] " + comment;
        }

        /// <summary>
        /// Gets or sets ゴールに設定する値定義.
        /// </summary>
        protected virtual int Count { get => count; set => count = value; }

        /// <summary>
        /// Convert to ai script format.
        /// </summary>
        /// <param name="indentLevel">Output indent level.</param>
        /// <returns>ai script.</returns>
        public override string ToScript(int indentLevel)
        {
            return base.ToScript(indentLevel);
        }
    }
}
