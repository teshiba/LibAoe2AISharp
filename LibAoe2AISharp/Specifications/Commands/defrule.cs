using System;
using LibAoe2AISharp.Utilty;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Generate defrule script.
    /// </summary>
    public abstract class defrule : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="defrule"/> class.
        /// </summary>
        protected defrule()
            : this(null, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="defrule"/> class.
        /// And set Fact list, Action list and debug action list.
        /// </summary>
        /// <param name="facts">Fact list(if set null, set default).</param>
        /// <param name="actions">Action list(if set null, set default).</param>
        /// <param name="debugActions">Debug action list(if set null, set default).</param>
        protected defrule(CommandCollection<ICondition> facts, CommandCollection<ICommand> actions, IDebug debugActions)
        {
            Comment = ClassName;
            Facts = facts ?? new FactCollection();
            Actions = actions ?? new ActionCollection();
            DebugActions = debugActions ?? new Debug();
        }

        /// <summary>
        /// Gets Fact list.
        /// </summary>
        public CommandCollection<ICondition> Facts { get; }

        /// <summary>
        /// Gets Action list.
        /// </summary>
        public CommandCollection<ICommand> Actions { get; }

        /// <summary>
        /// Gets Debug action list.
        /// </summary>
        public IDebug DebugActions { get; }

        /// <summary>
        /// Gets or sets defrule comment.
        /// </summary>
        public string Comment { get; set; }

        private string ClassName
        {
            get {
                var name = GetType().FullName;
                return name.Substring(name.IndexOf('.', StringComparison.Ordinal) + 1);
            }
        }

        /// <inheritdoc/>
        public virtual string ToScript(int indentLevel)
        {
            var ret = string.Empty;

            if (!string.IsNullOrEmpty(Comment)) {
                ret += ";" + Comment + Environment.NewLine;
            }

            indentLevel++;
            ret += "(" + "defrule" + Environment.NewLine;
            ret += Facts.ToScript(indentLevel);                 // NewLine in function
            ret += "=>" + Environment.NewLine;
            ret += Actions.ToScript(indentLevel);               // NewLine in function
            ret += DebugActions.ToScript(ClassName, Comment);   // NewLine in function
            ret += ")" + Environment.NewLine;
            return ret;
        }

        /// <inheritdoc/>
        public virtual string ToScript()
        {
            return ToScript(0);
        }
    }
}
