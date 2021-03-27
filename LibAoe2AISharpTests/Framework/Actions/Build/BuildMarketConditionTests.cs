using System;

using LibAoe2AISharp.Specifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class BuildMarketConditionTests
    {
        [TestMethod]
        public void BuildMarketConditionTest()
        {
            // Arrange
            var expectedValue = ";Build market up to 10." + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (can-build market) ;Can build market?" + Environment.NewLine +
                "    (building-type-count-total market < 10) ;Count of market" + Environment.NewLine +
                "    (or" + Environment.NewLine +
                "        (or" + Environment.NewLine +
                "            (and" + Environment.NewLine +
                "                (building-type-count-total archery-range >= 2) ;Count of archery-range" + Environment.NewLine +
                "                (player-in-game any-ally)" + Environment.NewLine +
                "            )" + Environment.NewLine +
                "            (and" + Environment.NewLine +
                "                (and ;Any ally has market" + Environment.NewLine +
                "                    (player-in-game any-ally)" + Environment.NewLine +
                "                    (players-building-type-count any-ally market >= 1)" + Environment.NewLine +
                "                )" + Environment.NewLine +
                "                (building-type-count-total archery-range >= 1) ;Count of archery-range" + Environment.NewLine +
                "            )" + Environment.NewLine +
                "        )" + Environment.NewLine +
                "        (and" + Environment.NewLine +
                "            (wood-amount >= 800) ;wood-amount" + Environment.NewLine +
                "            (building-type-count-total archery-range >= 2) ;Count of archery-range" + Environment.NewLine +
                "        )" + Environment.NewLine +
                "    )" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (build market) ;Build market" + Environment.NewLine +
                ")" + Environment.NewLine;

            // Act
            var testClass = new BuildMarketCondition(10) {
                AllyInGame = new building_type_count_total(building.archery_range, relop.ge, 2),
                AllyHasMarket = new building_type_count_total(building.archery_range, relop.ge, 1),
                NoAllyInGame = new wood_amount(relop.ge, 800)
                             & new building_type_count_total(building.archery_range, relop.ge, 2),
            };
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}