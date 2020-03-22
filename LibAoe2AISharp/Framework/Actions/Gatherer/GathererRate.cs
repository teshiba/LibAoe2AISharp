using System;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Manage resource gatherer rate.
    /// </summary>
    public class GathererRate : GathererNumber
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GathererRate"/> class.
        /// </summary>
        /// <param name="food">Rate[%] of total people collecting foods.</param>
        /// <param name="wood">Rate[%] of total people collecting woods.</param>
        /// <param name="gold">Rate[%] of total people collecting golds.</param>
        /// <param name="stone">Rate[%] of total people collecting stones.</param>
        public GathererRate(int food, int wood, int gold, int stone)
            : base(0, food, wood, gold, stone, true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GathererRate"/> class.
        /// Calculate and assign the percentage parameter for the property.
        /// </summary>
        /// <param name="gatherer">gatherer.</param>
        public GathererRate(GathererNumber gatherer)
            : this(0, 0, 0, 0) // Temporarily assigns a parameter.
        {
            int[] resource;
            if (gatherer == null) {
                throw new ArgumentNullException(nameof(gatherer));
            }

            if (gatherer.UnitPercentage) {
                resource = new int[] { gatherer.Food, gatherer.Wood, gatherer.Gold, gatherer.Stone };
            } else {
                var foodPct = (int)Math.Round((double)gatherer.Food * 100 / gatherer.Total);
                var woodPct = (int)Math.Round((double)gatherer.Wood * 100 / gatherer.Total);
                var goldPct = (int)Math.Round((double)gatherer.Gold * 100 / gatherer.Total);
                var stonePct = (int)Math.Round((double)gatherer.Stone * 100 / gatherer.Total);
                resource = new int[] { foodPct, woodPct, goldPct, stonePct };

                // Surplus values are added to the minimum value other than 0 to make the total 100.
                int minIndex = 0;
                for (int i = 1; i < resource.Length; i++) {
                    if (resource[i] != 0) {
                        if (resource[i] < resource[minIndex]) {
                            minIndex = i;
                        }
                    }
                }

                resource[minIndex] += 100 - foodPct - woodPct - goldPct - stonePct;
            }

            Food = resource[0];
            Wood = resource[1];
            Gold = resource[2];
            Stone = resource[3];
        }
    }
}
