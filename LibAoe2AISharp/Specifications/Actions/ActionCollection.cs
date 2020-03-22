using System;
using System.Linq;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Collection of Action command.
    /// </summary>
    public class ActionCollection : CommandCollection<ICommand>
    {
        /// <summary>
        /// Add Actions to collection.
        /// </summary>
        /// <param name="list">ActionList instance.</param>
        /// <param name="commands">Actions array.</param>
        public override void Add(CommandCollection<ICommand> list, params ICommand[] commands)
        {
            Add(list);
            Add(commands);
        }

        /// <summary>
        /// Add Actions to collection.
        /// </summary>
        /// <param name="list">ActionList instance.</param>
        public override void Add(CommandCollection<ICommand> list)
        {
            Add(list.ToArray());
        }

        /// <summary>
        /// Add Actions to collection.
        /// </summary>
        /// <param name="commands">Actions array.</param>
        public override void Add(params ICommand[] commands)
        {
            if (commands == null) {
                throw new ArgumentNullException(nameof(commands));
            }

            foreach (var item in commands) {
                Add(item);
            }
        }

        /// <inheritdoc/>
        public override string ToScript(int indentLevel)
        {
            if (Count == 0) {
                throw new InvalidOperationException();
            }

            var output = string.Empty;

            foreach (var item in this) {
                output += item.ToScript(indentLevel) + Environment.NewLine;
            }

            return output;
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(1);
        }
    }
}