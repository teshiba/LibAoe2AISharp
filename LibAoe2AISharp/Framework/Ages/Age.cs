namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Define age state value as goal-id.
    /// </summary>
    public class Age : GoalValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Age"/> class.
        /// </summary>
        /// <param name="constantName">constant-name.</param>
        /// <param name="comment">comment.</param>
        public Age(string constantName, string comment)
            : base(constantName, comment)
        {
        }
    }
}
