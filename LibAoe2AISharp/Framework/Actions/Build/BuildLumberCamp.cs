namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// Build Lumber camp.
    /// </summary>
    public class BuildLumberCamp : Build
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLumberCamp"/> class.
        /// </summary>
        public BuildLumberCamp()
            : base(building.lumber_camp)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLumberCamp"/> class.
        /// </summary>
        /// <param name="count">building count.</param>
        public BuildLumberCamp(int count)
            : base(building.lumber_camp, count)
        {
        }

        /// <summary>
        /// Gets or sets Distance between resource and Lumber camp.
        /// <para>
        /// 0 : Build ignore distance.
        /// </para>
        /// <para>
        /// greater than 0: Build if distance between resource and Lumber camp become the property.
        /// </para>
        /// </summary>
        public int Distance { get; set; }

        /// <inheritdoc/>
        public override string ToScript()
        {
            if (Distance > 0) {
                Comment += $" Distance more than {Distance}";
                Facts.Add(
                    new dropsite_min_distance(resource_type.wood, relop.ge, Distance));
            }

            return base.ToScript();
        }
    }
}
