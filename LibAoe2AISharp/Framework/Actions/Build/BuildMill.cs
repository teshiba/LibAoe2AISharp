namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// Build Mill.
    /// </summary>
    public class BuildMill : Build
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildMill"/> class.
        /// </summary>
        public BuildMill()
            : base(building.mill)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildMill"/> class.
        /// </summary>
        /// <param name="count">Max count of buildings.</param>
        public BuildMill(int count)
            : base(building.mill, count)
        {
        }

        /// <summary>
        /// Gets or sets Distance between resource and Mill.
        /// <para>
        /// 0 : Build ignore distance.
        /// </para>
        /// <para>
        /// greater than 0: Build if distance between resource and Mill become the property.
        /// </para>
        /// </summary>
        public int Distance { get; set; }

        /// <inheritdoc/>
        public override string ToScript()
        {
            if (Distance > 0) {
                Comment += $" Distance more than {Distance}";
                Facts.Add(new dropsite_min_distance(resource_type.food, relop.ge, Distance));
            }

            return base.ToScript();
        }
    }
}