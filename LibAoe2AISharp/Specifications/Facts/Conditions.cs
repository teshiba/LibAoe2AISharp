using System;
using System.Collections.Generic;
using static System.Environment;
using static LibAoe2AISharp.Specifications.Ope;
using static LibAoe2AISharp.Specifications.Script;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Manages two conditions.
    /// </summary>
    public class Conditions : ICondition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Conditions"/> class.
        /// </summary>
        /// <param name="constantFacts">true or false.</param>
        public Conditions(bool constantFacts)
        {
            if (!constantFacts) {
                Condition1 = new FalseFact();
            }

            Ope = Logical.And;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conditions"/> class.
        /// </summary>
        /// <param name="condition">AIFact or Conditions.</param>
        public Conditions(ICondition condition)
        {
            if (condition is Conditions cond) {
                Condition1 = cond.Condition1;
                Condition2 = cond.Condition2;
                Ope = cond.Ope;
            } else if (condition is AIFact fact) {
                Condition1 = fact;
                Condition2 = null;
                Ope = Logical.And;
            } else {
                throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conditions"/> class.
        /// </summary>
        /// <param name="cond1">1st condition.</param>
        /// <param name="cond2">another condition.</param>
        /// <param name="ope">Logical operator between cond1 and cond2.</param>
        public Conditions(ICondition cond1, ICondition cond2, Logical ope)
        {
            Condition1 = cond1 ?? throw new ArgumentNullException(nameof(cond1));

            switch (ope) {
            case Logical.Not:
                if (cond2 != null) {
                    throw new InvalidOperationException();
                }

                break;
            case Logical.And:
                break;
            case Logical.Or:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(cond2));
            }

            Condition2 = cond2;
            Ope = ope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conditions"/> class.
        /// </summary>
        /// <remarks>
        /// Optimize condition.
        /// <code>
        /// ope(and(A1,-),B) -> ope(A1,B)
        /// ope( or(A1,-),B) -> ope(A1,B)
        /// ope(not(A1,-),B) -> ope(not(A1,-),B)
        /// </code>
        /// </remarks>
        /// <param name="cond1">1st condition.</param>
        /// <param name="cond2">another condition.</param>
        /// <param name="ope">Logical operator between cond1 and cond2.</param>
        public Conditions(Conditions cond1, ICondition cond2, Logical ope)
            : this((ICondition)cond1, cond2, ope)
        {
            if (cond1.Condition2 == null
                && cond1.Ope != Logical.Not) {
                Condition1 = cond1.Condition1;
            }
        }

        /// <summary>
        /// Gets or Sets comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the condition.
        /// </summary>
        public ICondition Condition1 { get; protected set; }

        /// <summary>
        /// Gets or sets another condition.
        /// </summary>
        public ICondition Condition2 { get; protected set; }

        /// <summary>
        /// Gets or sets logical operator.
        /// </summary>
        public Logical Ope { get; protected set; }

        /// <summary>
        /// Cast AIFact to Conditions implicitly.
        /// </summary>
        /// <param name="fact">Fact of script.</param>
        public static implicit operator Conditions(AIFact fact)
        {
            return ToConditions(fact);
        }

        /// <summary>
        /// generate 'Not' conditions.
        /// <para><code>
        /// (not(`<paramref name="condition"/>`))
        /// </code></para>
        /// </summary>
        /// <param name="condition">conditions.</param>
        /// <returns>Not condition of <paramref name="condition"/>.</returns>
        public static Conditions operator !(Conditions condition)
        {
            return LogicalNot(condition);
        }

        /// <summary>
        /// generate 'Or' conditions.
        /// </summary>
        /// <param name="cond1">1st conditon.</param>
        /// <param name="cond2">another condition.</param>
        /// <returns><paramref name="cond1"/> or <paramref name="cond2"/> condition.</returns>
        public static Conditions operator |(Conditions cond1, ICondition cond2)
        {
            return BitwiseOr(cond1, cond2);
        }

        /// <summary>
        /// generate 'And' conditions.
        /// </summary>
        /// <param name="cond1">1st conditon.</param>
        /// <param name="cond2">another condition.</param>
        /// <returns><paramref name="cond1"/> and <paramref name="cond2"/> condition.</returns>
        public static Conditions operator &(Conditions cond1, ICondition cond2)
        {
            return BitwiseAnd(cond1, cond2);
        }

        /// <summary>
        /// Cast from AIFact to Conditions.
        /// </summary>
        /// <param name="fact">casted AIFact.</param>
        /// <returns>Conditions.</returns>
        public static Conditions ToConditions(AIFact fact)
        {
            return new Conditions(fact);
        }

        /// <summary>
        /// generate 'Or' conditions.
        /// </summary>
        /// <remarks>
        /// <code>
        /// ---------------------------------------------------------|
        /// ###################||              cond2                 |
        ///  condition matrix  ++------+-----------+-----------------|
        /// ###################|| null | falseFact |      other      |
        /// -------+-----------++------+-----------+-----------------|
        /// -------+-----------++------+-----------+-----------------|
        ///        | null      || true                               |
        ///        +-----------++------+-----------+-----------------|
        ///  cond1 | falseFact || cond2                              |
        ///        +-----------++------+-----------+-----------------|
        ///        | other     || true | cond1     |(cond1 or cond2) |
        /// -------+-----------++------+-----------+-----------------|
        /// </code>
        /// </remarks>
        /// <param name="cond1">1st conditon.</param>
        /// <param name="cond2">another condition.</param>
        /// <returns><paramref name="cond1"/> or <paramref name="cond2"/> condition.</returns>
        public static Conditions BitwiseOr(Conditions cond1, ICondition cond2)
        {
            Conditions ret;

            if (cond1?.Condition1 == null) {
                ret = new Conditions(true);
            } else if (cond1.Condition1 is FalseFact) {
                ret = new Conditions(cond2);
            } else { // other
                ICondition icond;

                switch (cond2) {
                case Conditions condObj:
                    icond = condObj.Condition1;
                    break;
                default: {
                    icond = cond2 is AIFact fact ? fact : throw new TypeAccessException();
                    break;
                }
                }

                switch (icond) {
                case null:
                    ret = new Conditions(true);
                    break;
                case FalseFact _:
                    ret = new Conditions(cond1);
                    break;
                default:
                    ret = new Conditions(cond1, cond2, Logical.Or);
                    break;
                }
            }

            return ret;
        }

        /// <summary>
        /// generate 'And' conditions.
        /// </summary>
        /// <remarks>
        /// <code>
        /// ------------------------------------------------------------|
        /// ###################||              cond2                    |
        ///  condition matrix  ++-------+-----------+-------------------|
        /// ###################|| null  | falseFact |      other        |
        /// -------+-----------++-------+-----------+-------------------|
        /// -------+-----------++-------+-----------+-------------------|
        ///  cond1 | null      || cond2                                 |
        /// -------+-----------++-------+-----------+-------------------|
        ///        | falseFact || falseFact                             |
        /// -------+-----------++-------+-----------+-------------------|
        ///        | other     || cond1 | falseFact | (cond1 and cond2) |
        /// -------+-----------++-------+-----------+-------------------|
        /// </code>
        /// </remarks>
        /// <param name="cond1">1st conditon.</param>
        /// <param name="cond2">another condition.</param>
        /// <returns><paramref name="cond1"/> and <paramref name="cond2"/> condition.</returns>
        public static Conditions BitwiseAnd(Conditions cond1, ICondition cond2)
        {
            Conditions ret;

            if (cond1?.Condition1 == null) {
                ret = new Conditions(cond2);
            } else if (cond1.Condition1 is FalseFact) {
                ret = new Conditions(cond1.Condition1);
            } else {// other
                ICondition icond;

                switch (cond2) {
                case Conditions condObj:
                    icond = condObj.Condition1;
                    break;
                default: {
                    icond = cond2 is AIFact fact ? fact : throw new TypeAccessException();
                    break;
                }
                }

                switch (icond) {
                case null:
                    ret = cond1;
                    break;
                case FalseFact _:
                    ret = new Conditions(icond);
                    break;
                default:
                    ret = new Conditions(cond1, cond2, Logical.And);
                    break;
                }
            }

            return ret;
        }

        /// <summary>
        /// generate 'Not' conditions.
        /// <para><code>
        /// (not(`<paramref name="condition"/>`))
        /// </code></para>
        /// </summary>
        /// <param name="condition">conditions.</param>
        /// <returns>Not condition of <paramref name="condition"/>.</returns>
        public static Conditions LogicalNot(Conditions condition)
        {
            if (condition == null) {
                throw new ArgumentNullException(nameof(condition));
            }

            var ret = new Conditions(condition.Condition1, condition.Condition2, condition.Ope);

            if (condition.Condition2 == null) {
                var keyValuePairs = new Dictionary<Logical, Logical>() {
                    { Logical.And, Logical.Not }, // and(A,-) -> not(A,-)
                    { Logical.Or,  Logical.Not }, //  or(A,-) -> not(A,-)
                    { Logical.Not, Logical.And }, // not(A,-) -> and(A,-)
                };
                ret.Ope = keyValuePairs[condition.Ope];
            } else {
                ret.Condition1 = condition;
                ret.Condition2 = null;
                ret.Ope = Logical.Not;
            }

            return ret;
        }

        /// <inheritdoc/>
        public string ToScript(int indentLevel)
        {
            string ret = string.Empty;

            if (Condition2 != null || Ope == Logical.Not) {
                var comment = !string.IsNullOrWhiteSpace(Comment) ? " ;" + Comment : string.Empty;
                ret += Tab(indentLevel) + "(" + Ope.ToScript() + comment + NewLine;

                // output condition recursively
                ret += GetCondition1Script(indentLevel + 1);

                ret += NewLine;
                ret += Condition2 != null ? Condition2.ToScript(indentLevel + 1) + NewLine : string.Empty;
                ret += Tab(indentLevel) + ")";
            } else {
                // output condition recursively
                ret += !string.IsNullOrWhiteSpace(Comment) ? Tab(indentLevel) + ";" + Comment + NewLine : string.Empty;
                ret += GetCondition1Script(indentLevel);
            }

            return ret;
        }

        /// <inheritdoc/>
        public string ToScript()
        {
            return ToScript(0);
        }

        private string GetCondition1Script(int indentLevel)
        {
            return Condition1?.ToScript(indentLevel) ?? new TrueFact().ToScript(indentLevel);
        }
    }
}