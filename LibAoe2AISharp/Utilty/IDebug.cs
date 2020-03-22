namespace LibAoe2AISharp.Utilty
{
    /// <summary>
    /// Debug output interface.
    /// </summary>
    public interface IDebug
    {
        /// <summary>
        /// Convert to ai script format.
        /// </summary>
        /// <param name="className">Debug target class name.</param>
        /// <param name="message">Displayed string as debug message.</param>
        /// <returns>ai script.</returns>
        string ToScript(string className, string message);
    }
}
