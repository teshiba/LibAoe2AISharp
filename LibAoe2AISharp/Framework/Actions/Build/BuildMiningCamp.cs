using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Build Mining camp.
    /// </summary>
    public class BuildMiningCamp : Build
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildMiningCamp"/> class.
        /// </summary>
        public BuildMiningCamp()
            : base(building.mining_camp)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildMiningCamp"/> class.
        /// </summary>
        /// <param name="count">Max count of buildings.</param>
        public BuildMiningCamp(int count)
            : base(building.mining_camp, count)
        {
        }

        /// <summary>
        /// Gets or sets Distance between resource and Mining camp.
        /// <para>
        /// 0 : Build ignore distance.
        /// </para>
        /// <para>
        /// greater than 0: Build if distance between resource and Mining camp become the property.
        /// </para>
        /// </summary>
        public int Distance { get; set; }

        /// <inheritdoc/>
        public override string ToScript()
        {
            if (Distance > 0) {
                Comment += $" Distance more than {Distance}";
                Facts.Add(
                      new dropsite_min_distance(resource_type.gold, relop.ge, Distance)
                    | new dropsite_min_distance(resource_type.stone, relop.ge, Distance));
            }

            return base.ToScript();
        }
    }
}
