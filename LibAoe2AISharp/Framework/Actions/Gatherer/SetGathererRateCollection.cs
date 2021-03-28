namespace LibAoe2AISharp.Framework
{
    using System;
    using LibAoe2AISharp.Specifications;

    /// <summary>
    /// Collection of gatherer rate action.
    /// </summary>
    public class SetGathererRateCollection : ActionCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetGathererRateCollection"/> class.
        /// </summary>
        /// <param name="gatherer">gatherer rate definition.</param>
        public SetGathererRateCollection(GathererNumber gatherer)
        {
            if (gatherer == null) {
                throw new ArgumentNullException(nameof(gatherer));
            }

            Comment = GetChatMessage(gatherer);
            Add(
                new set_strategic_number(sn.food_gatherer_percentage, new GathererRate(gatherer).Food),
                new set_strategic_number(sn.wood_gatherer_percentage, new GathererRate(gatherer).Wood),
                new set_strategic_number(sn.gold_gatherer_percentage, new GathererRate(gatherer).Gold),
                new set_strategic_number(sn.stone_gatherer_percentage, new GathererRate(gatherer).Stone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetGathererRateCollection"/> class.
        /// </summary>
        /// <param name="food">food rate[%].</param>
        /// <param name="wood">wood rate[%].</param>
        /// <param name="gold">gold rate[%].</param>
        /// <param name="stone">stone rate[%].</param>
        public SetGathererRateCollection(int food, int wood, int gold, int stone)
            : this(new GathererRate(food, wood, gold, stone))
        {
        }

        private static string GetChatMessage(GathererNumber gatherer)
        {
            string unit = gatherer.Unit == "%" ? "[%" : $"[total:{gatherer.Total}";
            return unit + $" F{gatherer.Food}, W{gatherer.Wood}, G{gatherer.Gold}, S{gatherer.Stone}]";
        }
    }
}
