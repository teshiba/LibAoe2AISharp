using System;

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
            var expectedValue = "(and ;Any ally has market" + Environment.NewLine +
                                "    (player-in-game any-ally)" + Environment.NewLine +
                                "    (players-building-type-count any-ally market >= 1)" + Environment.NewLine +
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
            var expectedValue = "(or ;Shepherd exist" + Environment.NewLine +
                                "    (unit-type-count-total ShepherdMan >= 1) ;Check count : unit ShepherdMan" + Environment.NewLine +
                                "    (unit-type-count-total ShepherdWoman >= 1) ;Check count : unit ShepherdWoman" + Environment.NewLine +
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
            var expectedValue = "(or ;Hunter exist" + Environment.NewLine +
                                "    (unit-type-count-total HunterMan >= 1) ;Check count : unit HunterMan" + Environment.NewLine +
                                "    (unit-type-count-total HunterWoman >= 1) ;Check count : unit HunterWoman" + Environment.NewLine +
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
            var expectedValue = "(or ;Fisher exist" + Environment.NewLine +
                                "    (unit-type-count-total FisherMan >= 1) ;Check count : unit FisherMan" + Environment.NewLine +
                                "    (unit-type-count-total FisherWoman >= 1) ;Check count : unit FisherWoman" + Environment.NewLine +
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
            var expectedValue = "(or ;Harvester exist" + Environment.NewLine +
                "    (unit-type-count-total HarvesterMan >= 1) ;Check count : unit HarvesterMan" + Environment.NewLine +
                "    (unit-type-count-total HarvesterWoman >= 1) ;Check count : unit HarvesterWoman" + Environment.NewLine +
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
            var expectedValue = "(or ;Miner exist" + Environment.NewLine +
                                "    (or" + Environment.NewLine +
                                "        (unit-type-count-total GoldMinerMan >= 1) ;Check count : unit GoldMinerMan" + Environment.NewLine +
                                "        (unit-type-count-total GoldMinerWoman >= 1) ;Check count : unit GoldMinerWoman" + Environment.NewLine +
                                "    )" + Environment.NewLine +
                                "    (or" + Environment.NewLine +
                                "        (unit-type-count-total StoneMinerMan >= 1) ;Check count : unit StoneMinerMan" + Environment.NewLine +
                                "        (unit-type-count-total StoneMinerWoman >= 1) ;Check count : unit StoneMinerWoman" + Environment.NewLine +
                                "    )" + Environment.NewLine +
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
            var expectedValue = "(or ;Farmer exist" + Environment.NewLine +
                                "    (unit-type-count-total FarmerMan >= 1) ;Check count : unit FarmerMan" + Environment.NewLine +
                                "    (unit-type-count-total FarmerWoman >= 1) ;Check count : unit FarmerWoman" + Environment.NewLine +
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
            var expectedValue = "(or ;Lumberjack exist" + Environment.NewLine +
                                "    (unit-type-count-total LumberjackMan >= 1) ;Check count : unit LumberjackMan" + Environment.NewLine +
                                "    (unit-type-count-total LumberjackWonam >= 1) ;Check count : unit LumberjackWonam" + Environment.NewLine +
                                ")";

            // Act
            var testClass = ComplexConditions.LumberjackExist();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}