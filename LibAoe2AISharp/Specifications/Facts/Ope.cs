namespace LibAoe2AISharp.Specifications
{
    using System.Collections.Generic;

    /// <summary>
    /// Operator definitions.
    /// </summary>
    public static class Ope
    {
        private static readonly Dictionary<relop, string> OperatorList
            = new () {
                { relop.less_than, "less-than" },
                { relop.less_or_equal, "less-or-equal" },
                { relop.greater_than, "greater-than" },
                { relop.greater_or_equal, "greater-or-equal" },
                { relop.equal, "equal" },
                { relop.not_equal, "not-equal" },
                { relop.lt, "<" },
                { relop.le, "<=" },
                { relop.gt, ">" },
                { relop.ge, ">=" },
                { relop.eq, "==" },
                { relop.ne, "!=" },
            };

        /// <summary>
        /// Operator of IConditions.
        /// </summary>
        public enum Logical
        {
            /// <summary>
            /// Not condition.
            /// </summary>
            Not,

            /// <summary>
            /// And condition.
            /// </summary>
            And,

            /// <summary>
            /// Or condition.
            /// </summary>
            Or,
        }

        /// <summary>
        /// Relational operator.
        /// </summary>
        public enum relop
        {
            /// <summary>
            /// less than
            /// </summary>
            less_than,

            /// <summary>
            /// less or equal
            /// </summary>
            less_or_equal,

            /// <summary>
            /// greater than
            /// </summary>
            greater_than,

            /// <summary>
            /// greater or equal
            /// </summary>
            greater_or_equal,

            /// <summary>
            /// equal
            /// </summary>
            equal,

            /// <summary>
            /// not equal
            /// </summary>
            not_equal,

            /// <summary>
            /// less than ( "＜" short version)
            /// </summary>
            lt,

            /// <summary>
            /// less or equal (short version "＜" )
            /// </summary>
            le,

            /// <summary>
            /// greater than
            /// </summary>
            gt,

            /// <summary>
            /// greater or equal (short version ">=" )
            /// </summary>
            ge,

            /// <summary>
            /// equal (short version "==" )
            /// </summary>
            eq,

            /// <summary>
            /// not equal (short version "!=" )
            /// </summary>
            ne,
        }

        /// <summary>
        /// Converts logical operatior to ai script.
        /// </summary>
        /// <param name="op">operator.</param>
        /// <returns>ai script.</returns>
        public static string ToScript(this Logical op)
        {
            var textInfo = new System.Globalization.CultureInfo("en-US").TextInfo;
            return textInfo.ToLower(op.ToString());
        }

        /// <summary>
        /// Converts relational operatior to ai script.
        /// </summary>
        /// <param name="ope">enum <see cref="relop"/>.</param>
        /// <returns>ai script.</returns>
        public static string ToScript(this relop ope)
        {
            return OperatorList[ope];
        }
    }
}
