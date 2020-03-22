using static LibAoe2AISharp.Specifications.Script;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Abstract class for implement Action command.
    /// </summary>
    public abstract class AIAction : ICommand
    {
        /// <summary>
        /// Gets or Sets Comment which is commented to the end of the command.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets Action command name.
        /// </summary>
        protected virtual string Name => Convert(GetType().Name);

        /// <inheritdoc/>
        public abstract string ToScript();

        /// <inheritdoc/>
        public string ToScript(int indentLevel)
        {
            return Tab(indentLevel) + ToScript();
        }

        /// <summary>
        /// Converts to the Action command format
        /// with the inherited class name as the command name.
        /// </summary>
        /// <param name="parameters">Set (object)null if no arguments need.</param>
        /// <returns>Action command string.</returns>
        protected virtual string ToScript(params object[] parameters)
        {
            return Format(Name, Comment, parameters);
        }
    }
}
