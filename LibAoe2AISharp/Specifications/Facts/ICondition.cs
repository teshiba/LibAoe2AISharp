namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Condition interface.
    /// </summary>
    public interface ICondition
    {
        /// <summary>
        /// Gets or sets comment of the conditions.
        /// </summary>
        string Comment { get; set; }

        /// <summary>
        /// Converts to AI script with indent.
        /// </summary>
        /// <param name="indentLevel">Output indent level.</param>
        /// <returns>AI script.</returns>
        string ToScript(int indentLevel);

        /// <summary>
        /// Converts to AI script.
        /// </summary>
        /// <returns>AI script.</returns>
        string ToScript();
    }
}