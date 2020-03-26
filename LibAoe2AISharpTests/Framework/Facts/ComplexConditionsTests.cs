using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class ComplexConditionsTests
    {
        [TestMethod]
        public void AnyAllyHasMarketTest()
        {
            // Arrange
            var expectedValue = "(and ;Any ally has market\r\n" +
                                "    (player-in-game any-ally)\r\n" +
                                "    (players-building-type-count any-ally market >= 1)\r\n" +
                                ")";

            // Act
            var testClass = ComplexConditions.AnyAllyHasMarket();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ShepherdExistTest()
        {
            // Arrange
            var expectedValue = "(or ;Shepherd exist\r\n" +
                                "    (unit-type-count-total ShepherdMan >= 1) ;Check count : unit ShepherdMan\r\n" +
                                "    (unit-type-count-total ShepherdWoman >= 1) ;Check count : unit ShepherdWoman\r\n" +
                                ")";

            // Act
            var testClass = ComplexConditions.ShepherdExist();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void HunterExistTest()
        {
            // Arrange
            var expectedValue = "(or ;Hunter exist\r\n" +
                                "    (unit-type-count-total HunterMan >= 1) ;Check count : unit HunterMan\r\n" +
                                "    (unit-type-count-total HunterWoman >= 1) ;Check count : unit HunterWoman\r\n" +
                                ")";

            // Act
            var testClass = ComplexConditions.HunterExist();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FisherExistTest()
        {
            // Arrange
            var expectedValue = "(or ;Fisher exist\r\n" +
                                "    (unit-type-count-total FisherMan >= 1) ;Check count : unit FisherMan\r\n" +
                                "    (unit-type-count-total FisherWoman >= 1) ;Check count : unit FisherWoman\r\n" +
                                ")";

            // Act
            var testClass = ComplexConditions.FisherExist();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void HarvesterExistTest()
        {
            // Arrange
            var expectedValue = "(or ;Harvester exist\r\n" +
                "    (unit-type-count-total HarvesterMan >= 1) ;Check count : unit HarvesterMan\r\n" +
                "    (unit-type-count-total HarvesterWoman >= 1) ;Check count : unit HarvesterWoman\r\n" +
                ")";

            // Act
            var testClass = ComplexConditions.HarvesterExist();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void MinerExistTest()
        {
            // Arrange
            var expectedValue = "(or ;Miner exist\r\n" +
                                "    (or\r\n" +
                                "        (unit-type-count-total GoldMinerMan >= 1) ;Check count : unit GoldMinerMan\r\n" +
                                "        (unit-type-count-total GoldMinerWoman >= 1) ;Check count : unit GoldMinerWoman\r\n" +
                                "    )\r\n" +
                                "    (or\r\n" +
                                "        (unit-type-count-total StoneMinerMan >= 1) ;Check count : unit StoneMinerMan\r\n" +
                                "        (unit-type-count-total StoneMinerWoman >= 1) ;Check count : unit StoneMinerWoman\r\n" +
                                "    )\r\n" +
                                ")";

            // Act
            var testClass = ComplexConditions.MinerExist();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FarmerExistTest()
        {
            // Arrange
            var expectedValue = "(or ;Farmer exist\r\n" +
                                "    (unit-type-count-total FarmerMan >= 1) ;Check count : unit FarmerMan\r\n" +
                                "    (unit-type-count-total FarmerWoman >= 1) ;Check count : unit FarmerWoman\r\n" +
                                ")";

            // Act
            var testClass = ComplexConditions.FarmerExist();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void LumberjackExistTest()
        {
            // Arrange
            var expectedValue = "(or ;Lumberjack exist\r\n" +
                                "    (unit-type-count-total LumberjackMan >= 1) ;Check count : unit LumberjackMan\r\n" +
                                "    (unit-type-count-total LumberjackWonam >= 1) ;Check count : unit LumberjackWonam\r\n" +
                                ")";

            // Act
            var testClass = ComplexConditions.LumberjackExist();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}