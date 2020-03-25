using System;
using static LibAoe2AISharp.Specifications.Ope;
using static LibAoe2AISharp.Specifications.Script;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Abstract class for implement Fact command.
    /// </summary>
    public abstract class AIFact : ICondition
    {
        /// <summary>
        /// Gets or Sets Comment which is commented to the end of the command.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Fact is 'Not' condition.
        /// </summary>
        public bool IsNot { get; set; }

        /// <summary>
        /// Gets Fact command name.
        /// </summary>
        protected virtual string Name => Convert(GetType().Name);

        /// <summary>
        /// return 'Not' condition for generating "(not (`fact command`))" command.
        /// </summary>
        /// <param name="fact">this.</param>
        /// <returns>Not condition of the argument.</returns>
        public static AIFact operator !(AIFact fact)
        {
            return LogicalNot(fact);
        }

        /// <summary>
        /// Generate 'Or' condition.
        /// </summary>
        /// <param name="fact1">this.</param>
        /// <param name="fact2">target of 'Or' condition.</param>
        /// <returns>Condition of (fact1 or fact2).</returns>
        public static Conditions operator |(AIFact fact1, ICondition fact2)
        {
            return BitwiseOr(fact1, fact2);
        }

        /// <summary>
        /// Generate 'And' condition.
        /// </summary>
        /// <param name="fact1">this.</param>
        /// <param name="fact2">target of 'And' condition.</param>
        /// <returns>Condition of (fact1 and fact2).</returns>
        public static Conditions operator &(AIFact fact1, ICondition fact2)
        {
            return BitwiseAnd(fact1, fact2);
        }

        /// <summary>
        /// return 'Not' condition for generating "(not (`fact command`))" command.
        /// </summary>
        /// <param name="fact">this.</param>
        /// <returns>Not condition of the argument.</returns>
        public static AIFact LogicalNot(AIFact fact)
        {
            var ret = (AIFact)fact?.MemberwiseClone()
                    ?? throw new ArgumentNullException(nameof(fact));

            ret.IsNot = !ret.IsNot;

            return ret;
        }

        /// <summary>
        /// Generate 'Or' condition.
        /// </summary>
        /// <param name="fact1">this.</param>
        /// <param name="fact2">target of 'Or' condition.</param>
        /// <returns>Condition of (fact1 or fact2).</returns>
        public static Conditions BitwiseOr(ICondition fact1, ICondition fact2)
        {
            return new Conditions(fact1, fact2, Logical.Or);
        }

        /// <summary>
        /// Generate 'And' condition.
        /// </summary>
        /// <param name="fact1">this.</param>
        /// <param name="fact2">target of 'And' condition.</param>
        /// <returns>Condition of (fact1 and fact2).</returns>
        public static Conditions BitwiseAnd(ICondition fact1, ICondition fact2)
        {
            return new Conditions(fact1, fact2, Logical.And);
        }

        /// <inheritdoc/>
        public abstract string ToScript();

        /// <inheritdoc/>
        public string ToScript(int indentLevel)
        {
            return Tab(indentLevel) + ToScript();
        }

        /// <summary>
        /// Converts to the Fact command format
        /// with the inherited class name as the command name.
        /// </summary>
        /// <param name="parameters">Set (object)null if no arguments need.</param>
        /// <returns>Fact command string.</returns>
        protected string ToScript(params object[] parameters)
        {
            var ret = Format(Name, Comment, parameters);

            if (IsNot) {
                ret = "(not " + ret.Replace(")", "))");
            }

            return ret;
        }
    }
}