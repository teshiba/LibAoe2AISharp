namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;
    using static LibAoe2AISharp.Framework.ComplexConditions;

    /// <summary>
    /// Build market according to ally conditions.
    /// </summary>
    public class BuildMarketCondition : Build
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildMarketCondition"/> class.
        /// </summary>
        /// <param name="count">build count.</param>
        public BuildMarketCondition(short count)
            : base(building.market, count)
        {
        }

        /// <summary>
        /// Gets or sets condition for ally in game.
        /// </summary>
        public Conditions AllyInGame { get; set; } = new Conditions(true);

        /// <summary>
        /// Gets or sets condition for ally has market.
        /// </summary>
        public Conditions AllyHasMarket { get; set; } = new Conditions(true);

        /// <summary>
        /// Gets or sets condition for no ally in game.
        /// </summary>
        public Conditions NoAllyInGame { get; set; } = new Conditions(true);

        /// <inheritdoc/>
        public override string ToScript()
        {
            Facts.Add(
                  (AllyInGame & new player_in_game(player_number.any_ally))
                | (AnyAllyHasMarket() & AllyHasMarket)
                | NoAllyInGame);
            return base.ToScript();
        }
    }
}
