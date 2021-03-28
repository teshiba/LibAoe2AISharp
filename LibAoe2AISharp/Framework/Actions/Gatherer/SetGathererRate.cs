namespace LibAoe2AISharp.Framework
{
    using System;
    using LibAoe2AISharp.Specifications;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// Set strategic number of resources gatherer percentage.
    /// </summary>
    /// Make following defrules.
    /// <code>
    /// (set-strategic-number sn-food-gatherer-percentage 50)
    /// (set-strategic-number sn-wood-gatherer-percentage 30)
    /// (set-strategic-number sn-gold-gatherer-percentage 15)
    /// (set-strategic-number sn-stone-gatherer-percentage 5)
    /// (disable-self);.
    /// </code>
    public class SetGathererRate : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetGathererRate"/> class.
        /// </summary>
        /// <param name="food">Rate[%] of total people collecting foods.</param>
        /// <param name="wood">Rate[%] of total people collecting woods.</param>
        /// <param name="gold">Rate[%] of total people collecting golds.</param>
        /// <param name="stone">Rate[%] of total people collecting stones.</param>
        public SetGathererRate(int food, int wood, int gold, int stone)
            : this(food, wood, gold, stone, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetGathererRate"/> class.
        /// </summary>
        /// <param name="food">Rate[%] of total people collecting foods.</param>
        /// <param name="wood">Rate[%] of total people collecting woods.</param>
        /// <param name="gold">Rate[%] of total people collecting golds.</param>
        /// <param name="stone">Rate[%] of total people collecting stones.</param>
        /// <param name="comment">Comment.</param>
        public SetGathererRate(int food, int wood, int gold, int stone, string comment)
            : this(new GathererRate(food, wood, gold, stone), null, comment)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetGathererRate"/> class.
        /// </summary>
        /// <param name="food">Rate[%] of total people collecting foods.</param>
        /// <param name="wood">Rate[%] of total people collecting woods.</param>
        /// <param name="gold">Rate[%] of total people collecting golds.</param>
        /// <param name="stone">Rate[%] of total people collecting stones.</param>
        /// <param name="condition">Conditions of setting gatherer rate.</param>
        public SetGathererRate(int food, int wood, int gold, int stone, ICondition condition)
            : this(new GathererRate(food, wood, gold, stone), condition, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetGathererRate"/> class.
        /// </summary>
        /// <param name="food">Rate[%] of total people collecting foods.</param>
        /// <param name="wood">Rate[%] of total people collecting woods.</param>
        /// <param name="gold">Rate[%] of total people collecting golds.</param>
        /// <param name="stone">Rate[%] of total people collecting stones.</param>
        /// <param name="condition">Conditions of setting gatherer rate.</param>
        /// <param name="comment">Comment.</param>
        public SetGathererRate(int food, int wood, int gold, int stone, ICondition condition, string comment)
            : this(new GathererRate(food, wood, gold, stone), condition, comment)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetGathererRate"/> class.
        /// </summary>
        /// <param name="total">Number of total people collecting resources.</param>
        /// <param name="food">Number of people collecting foods.</param>
        /// <param name="wood">Number of people collecting trees.</param>
        /// <param name="gold">Number of people collecting golds.</param>
        /// <param name="stone">Number of people collecting stones.</param>
        public SetGathererRate(int total, int food, int wood, int gold, int stone)
            : this(total, food, wood, gold, stone, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetGathererRate"/> class.
        /// </summary>
        /// <param name="total">Number of total people collecting resources.</param>
        /// <param name="food">Number of people collecting foods.</param>
        /// <param name="wood">Number of people collecting trees.</param>
        /// <param name="gold">Number of people collecting golds.</param>
        /// <param name="stone">Number of people collecting stones.</param>
        /// <param name="condition">Conditions of setting gatherer rate.</param>
        public SetGathererRate(int total, int food, int wood, int gold, int stone, ICondition condition)
            : this(total, food, wood, gold, stone, condition, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetGathererRate"/> class.
        /// </summary>
        /// <param name="total">Number of total people collecting resources.</param>
        /// <param name="food">Number of people collecting foods.</param>
        /// <param name="wood">Number of people collecting trees.</param>
        /// <param name="gold">Number of people collecting golds.</param>
        /// <param name="stone">Number of people collecting stones.</param>
        /// <param name="condition">Conditions of setting gatherer rate.</param>
        /// <param name="comment">Comment.</param>
        public SetGathererRate(
            int total, int food, int wood, int gold, int stone, ICondition condition, string comment)
            : this(new GathererNumber(total, food, wood, gold, stone), condition, comment)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetGathererRate"/> class.
        /// </summary>
        /// <param name="gatherer"> gatherer rate.</param>
        /// <param name="condition">Condtion for settings.</param>
        /// <param name="comment">Comment.</param>
        public SetGathererRate(GathererNumber gatherer, ICondition condition, string comment)
        {
            if (gatherer == null) {
                throw new ArgumentNullException(nameof(gatherer));
            }

            if (!gatherer.UnitPercentage) {
                Facts.Add(new unit_type_count(unit.villager, relop.eq, gatherer.Total));
            }

            if (condition != null) {
                Facts.Add(condition);
            }

            var gathererActions = new SetGathererRateCollection(gatherer) {
                new disable_self(),
            };
            Comment = gathererActions.Comment + (string.IsNullOrEmpty(comment) ? string.Empty : ":" + comment);
            Actions.Add(gathererActions);
        }
    }
}
