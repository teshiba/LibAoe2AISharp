namespace LibAoe2AISharp.Specifications
{
    using System;
    using System.Linq;
    using static LibAoe2AISharp.Specifications.Ope;
    using static LibAoe2AISharp.Specifications.Script;

    /// <summary>
    /// Collection of Fact command.
    /// </summary>
    public class FactCollection : CommandCollection<ICondition>
    {
        /// <summary>
        /// Add Conditions to collection.
        /// </summary>
        /// <param name="list">condition collection.</param>
        /// <param name="commands">condition array.</param>
        public override void Add(CommandCollection<ICondition> list, params ICondition[] commands)
        {
            Add(list);
            Add(commands);
        }

        /// <summary>
        /// Add Conditions to collection.
        /// </summary>
        /// <param name="list">condition collection.</param>
        public override void Add(CommandCollection<ICondition> list)
        {
            Add(list.ToArray());
        }

        /// <summary>
        /// Add a Condition to collection.
        /// </summary>
        /// <param name="command">command.</param>
        public override void Add(ICondition command)
        {
            // Shrink the first "and" operator, if item is Conditios.
            var cond = command as Conditions;
            if (cond?.Ope == Logical.And) {
                base.Add(cond.Condition1);
                if (cond.Condition2 != null) {
                    base.Add(cond.Condition2);
                }
            } else {
                base.Add(command);
            }
        }

        /// <summary>
        /// Add Conditions to collection.
        /// </summary>
        /// <param name="commands">condition array.</param>
        public override void Add(params ICondition[] commands)
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
            var ret = string.Empty;
            foreach (var item in this) {
                ret += Convert(item.ToScript(indentLevel)) + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(ret)) {
                ret = new TrueFact().ToScript(indentLevel) + Environment.NewLine;
            }

            return ret;
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(0);
        }
    }
}
