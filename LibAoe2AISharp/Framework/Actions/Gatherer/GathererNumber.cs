namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Manage resource gatherer.
    /// </summary>
    public class GathererNumber
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GathererNumber"/> class.
        /// </summary>
        /// <param name="total">Number of total people collecting resources.</param>
        /// <param name="food">Number of people collecting foods.</param>
        /// <param name="wood">Number of people collecting trees.</param>
        /// <param name="gold">Number of people collecting golds.</param>
        /// <param name="stone">Number of people collecting stones.</param>
        public GathererNumber(int total, int food, int wood, int gold, int stone)
            : this(total, food, wood, gold, stone, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GathererNumber"/> class.
        /// </summary>
        /// <param name="total">Value of total people collecting resources.</param>
        /// <param name="food">Value of people collecting foods.</param>
        /// <param name="wood">Value of people collecting trees.</param>
        /// <param name="gold">Value of people collecting golds.</param>
        /// <param name="stone">Value of people collecting stones.</param>
        /// <param name="unitPercentage">resource value unit: % is true, number of people is false.</param>
        protected GathererNumber(int total, int food, int wood, int gold, int stone, bool unitPercentage)
        {
            Total = total;
            Food = food;
            Wood = wood;
            Gold = gold;
            Stone = stone;
            UnitPercentage = unitPercentage;
            Unit = unitPercentage ? "%" : "count";
        }

        /// <summary>
        /// Gets or sets Value of total people collecting resources.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets Value of people collecting foods.
        /// </summary>
        public int Food { get; set; }

        /// <summary>
        /// Gets or sets Value of people collecting woods.
        /// </summary>
        public int Wood { get; set; }

        /// <summary>
        /// Gets or sets Value of people collecting golds.
        /// </summary>
        public int Gold { get; set; }

        /// <summary>
        /// Gets or sets Value of people collecting stones.
        /// </summary>
        public int Stone { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether unit is % or number of people.
        /// </summary>
        public bool UnitPercentage { get; set; }

        /// <summary>
        /// Gets unit string.
        /// </summary>
        public string Unit { get; }
    }
}