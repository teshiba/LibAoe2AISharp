namespace LibAoe2AISharp.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using LibAoe2AISharp.Specifications;
    using LibAoe2AISharp.Utilty;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// conditions whether given resource amount has enough.
    /// </summary>
    public class ResourceAmount : Conditions
    {
        /// <summary>
        /// resource cost list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "<List>")]
        private static readonly Dictionary<Enum, Cost> List = new () {
            // buildings
            { building.farm,             new Cost() { W =  60          } },
            { building.mill,             new Cost() { W = 100          } },
            { building.house,            new Cost() { W =  25          } },
            { building.lumber_camp,      new Cost() { W = 100          } },
            { building.mining_camp,      new Cost() { W = 100          } },
            { building.blacksmith,       new Cost() { W = 150          } },
            { building.university,       new Cost() { W = 200          } },
            { building.barracks,         new Cost() { W = 175          } },
            { building.archery_range,    new Cost() { W = 175          } },
            { building.town_center,      new Cost() { W = 275, S = 100 } },
            { building.monastery,        new Cost() { W = 175          } },
            { building.stable,           new Cost() { W = 175          } },
            { building.siege_workshop,   new Cost() { W = 200          } },

            // units
            { unit.villager,             new Cost() { F =  50                   } },
            { unit.knight,               new Cost() { F =  60,          G = 75  } },
            { unit.militiaman_line,      new Cost() { F =  60,          G = 20  } },
            { unit.eagle_warrior_line,   new Cost() { F =  20,          G = 50  } },
            { unit.skirmisher_line,      new Cost() { F =  25, W =  35          } },
            { unit.trade_cart,           new Cost() {          W = 100, G = 50  } },
            { unit.archer_line,          new Cost() {          W =  25, G = 45  } },
            { unit.camel_line,           new Cost() { F =  55,          G = 60  } },

            // researches
            { ri.horse_collar,           new Cost() { F =  75, W = 75         } },
            { ri.fletching,              new Cost() { F = 100,         G = 50 } },

            // ages
            { ri.feudal_age,             new Cost() { F =  500          } },
            { ri.castle_age,             new Cost() { F =  800, G = 200 } },
            { ri.imperial_age,           new Cost() { F = 1000, G = 800 } },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAmount"/> class.
        /// <para>
        /// Generate following facts.
        /// <see cref="food_amount"/> or
        /// <see cref="wood_amount"/> or
        /// <see cref="gold_amount"/> or
        /// <see cref="stone_amount"/>.
        /// </para>
        /// </summary>
        /// <param name="param"><see cref="building"/> or <see cref="unit"/> or <see cref="ri"/>.</param>
        public ResourceAmount(params Enum[] param)
            : base(true)
        {
            var foodComment = string.Empty;
            var woodComment = string.Empty;
            var goldComment = string.Empty;
            var stoneComment = string.Empty;
            int foodAmount = 0;
            int woodAmount = 0;
            int goldAmount = 0;
            int stoneAmount = 0;

            // Gather the cost of the given object by resources.
            foreach (var item in param) {
                foodAmount += List[item].F;
                woodAmount += List[item].W;
                goldAmount += List[item].G;
                stoneAmount += List[item].S;

                foodComment += GetComment(List[item].F, item);
                woodComment += GetComment(List[item].W, item);
                goldComment += GetComment(List[item].G, item);
                stoneComment += GetComment(List[item].S, item);
            }

            // Generate condition using each resource amount fact.
            var amountConditon = new Conditions(true);

            if (foodAmount != 0) {
                Food = new food_amount(relop.ge, foodAmount);
                Food.Comment += foodComment;
                amountConditon &= Food;
            }

            if (woodAmount != 0) {
                Wood = new wood_amount(relop.ge, woodAmount);
                Wood.Comment += woodComment;
                amountConditon &= Wood;
            }

            if (goldAmount != 0) {
                Gold = new gold_amount(relop.ge, goldAmount);
                Gold.Comment += goldComment;
                amountConditon &= Gold;
            }

            if (stoneAmount != 0) {
                Stone = new stone_amount(relop.ge, stoneAmount);
                Stone.Comment += stoneComment;
                amountConditon &= Stone;
            }

            Condition1 = amountConditon.Condition1;
            Condition2 = amountConditon.Condition2;
            Ope = Logical.And;
        }

        /// <summary>
        /// Gets food amount fact.
        /// </summary>
        public food_amount Food { get; }

        /// <summary>
        /// Gets wood amount fact.
        /// </summary>
        public wood_amount Wood { get; }

        /// <summary>
        /// Gets gold amount fact.
        /// </summary>
        public gold_amount Gold { get; }

        /// <summary>
        /// Gets stone amount fact.
        /// </summary>
        public stone_amount Stone { get; }

        private static string GetComment(int cost, Enum item)
        {
            var ret = string.Empty;

            if (cost != 0) {
                ret = " " + item.ToLocalLang() + ",";
            }

            return ret;
        }

        /// <summary>
        /// Structure of resources.
        /// </summary>
        private struct Cost
        {
            /// <summary>
            /// Gets or sets food cost.
            /// </summary>
            public int F { get; set; }

            /// <summary>
            /// Gets or sets wood cost.
            /// </summary>
            public int W { get; set; }

            /// <summary>
            /// Gets or sets gold cost.
            /// </summary>
            public int G { get; set; }

            /// <summary>
            /// Gets or sets stone cost.
            /// </summary>
            public int S { get; set; }
        }
    }
}