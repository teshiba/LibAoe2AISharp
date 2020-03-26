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
            var expectedValue = ";Build market up to 10.\r\n" +
                "(defrule\r\n" +
                "    (can-build market) ;Can build market?\r\n" +
                "    (building-type-count-total market < 10) ;Count of market\r\n" +
                "    (or\r\n" +
                "        (or\r\n" +
                "            (and\r\n" +
                "                (building-type-count-total archery-range >= 2) ;Count of archery-range\r\n" +
                "                (player-in-game any-ally)\r\n" +
                "            )\r\n" +
                "            (and\r\n" +
                "                (and ;Any ally has market\r\n" +
                "                    (player-in-game any-ally)\r\n" +
                "                    (players-building-type-count any-ally market >= 1)\r\n" +
                "                )\r\n" +
                "                (building-type-count-total archery-range >= 1) ;Count of archery-range\r\n" +
                "            )\r\n" +
                "        )\r\n" +
                "        (and\r\n" +
                "            (wood-amount >= 800) ;wood-amount\r\n" +
                "            (building-type-count-total archery-range >= 2) ;Count of archery-range\r\n" +
                "        )\r\n" +
                "    )\r\n" +
                "=>\r\n" +
                "    (build market) ;Build market\r\n" +
                ")\r\n";

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