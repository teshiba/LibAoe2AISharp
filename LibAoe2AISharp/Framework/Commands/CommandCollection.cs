namespace LibAoe2AISharp.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using LibAoe2AISharp.Specifications;

    /// <summary>
    /// Grouping multiple AI script commands.
    /// </summary>
    public class CommandCollection : Collection<ICommand>
    {
        /// <summary>
        /// Returns the default delimiter string for comment.
        /// </summary>
        public static readonly string SeparatorLine = ";" + new string('=', 79) + Environment.NewLine;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandCollection"/> class.
        /// </summary>
        public CommandCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandCollection"/> class.
        /// </summary>
        /// <param name="comment">comment of command collection.</param>
        public CommandCollection(string comment)
        {
            Comment = comment;
        }

        /// <summary>
        /// Gets or Sets comment of description.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets common Facts of group.
        /// </summary>
        public Collection<ICondition> CommonFacts { get; } = new Collection<ICondition>();

        /// <summary>
        /// Converts to AI script.
        /// </summary>
        /// <returns>AI script.</returns>
        public virtual string ToScript()
        {
            // Add common comment before outputing.
            if (CommonFacts.Count != 0) {
                foreach (var item in this) {
                    if (item is defrule rule) {
                        rule.Facts.Add(CommonFacts.ToArray());
                        rule.Comment = CommonFacts[0].Comment + ": " + rule.Comment;
                    }
                }
            }

            // Output commands.
            var ret = HeaderComment();
            foreach (var item in this) {
                ret += item.ToScript() + Environment.NewLine;
            }

            return ret;
        }

        /// <summary>
        /// Add command collection.
        /// </summary>
        /// <param name="group">command group.</param>
        public void Add(IEnumerable<ICommand> group)
        {
            if (group == null) {
                throw new ArgumentNullException(nameof(group));
            }

            foreach (var item in group) {
                Add(item);
            }
        }

        /// <summary>
        /// Returns a header comment on the group.
        /// </summary>
        /// <returns>Comment strings.</returns>
        protected virtual string HeaderComment()
        {
            var headerComment = SeparatorLine;

            headerComment += ";description: " + Comment + Environment.NewLine;

            if (CommonFacts.Count != 0) {
                headerComment += ";common fact: " + CommonFacts[0].Comment + Environment.NewLine;
            }

            // Output group element comments.
            foreach (var item in this) {
                // Exclude defconst that is output in one line,
                if (item is not defconst) {
                    headerComment += "; " + item.Comment + Environment.NewLine;
                }
            }

            headerComment += SeparatorLine;

            return headerComment;
        }
    }
}