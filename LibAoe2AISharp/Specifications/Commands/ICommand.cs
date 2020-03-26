namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// AI script command interface.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Gets comment of command.
        /// </summary>
        string Comment { get; }

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