using System;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// AI script formatter.
    /// </summary>
    public static class Script
    {
        /// <summary>
        /// Change "_" in the string to "-".
        /// </summary>
        /// <param name="className">Class name in which "-" in AI command name is changed to "_".</param>
        /// <returns>string which is changed "_" to "-".</returns>
        public static string Convert(string className)
        {
            return className?.Replace("_", "-", StringComparison.Ordinal);
        }

        /// <summary>
        /// Get command formatted string.
        /// <para><code>
        /// (<paramref name="command"/> <paramref name="parameters"/>[0]
        /// <paramref name="parameters"/>[1] <paramref name="parameters"/>[2]) ;comment
        /// </code></para>
        /// </summary>
        /// <param name="command">Name of command, fact and action.</param>
        /// <param name="comment">Comment given at the end of the command.</param>
        /// <param name="parameters">Command parameters.</param>
        /// <returns>formatted string.</returns>
        public static string Format(string command, string comment, params object[] parameters)
        {
            var ret = "(" + command;

            if (parameters != null) {
                foreach (var item in parameters) {
                    if (item != null) {
                        ret += " " + Convert(item.ToString());
                    }
                }
            }

            ret += ")";
            if (!string.IsNullOrEmpty(comment)) {
                ret += " ;" + comment;
            }

            return ret;
        }

        /// <summary>
        /// Output Tabs.
        /// </summary>
        /// <param name="indentLevel">indent level.</param>
        /// <returns>Spaces as tabs.</returns>
        public static string Tab(int indentLevel)
        {
            return new string(' ', indentLevel * 4);
        }

        /// <summary>
        /// Check for no spaces.
        /// </summary>
        /// <exception cref="ArgumentException">throw exception if value contains spaces.</exception>
        /// <param name="value">Strings to be checked.</param>
        public static void AssertContainsNoSpaces(string value)
        {
            if (value?.Contains(" ", StringComparison.Ordinal) == true) {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
    }
}