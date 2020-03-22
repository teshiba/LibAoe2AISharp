using System;
using System.Collections.Generic;
using LibAoe2AISharp.Specifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class ResourceAmountTests
    {
        [TestMethod]
        public void ResourceAmountTest()
        {
            // Arrange
            var expectedValue = "(and\r\n" +
                                "    (and\r\n" +
                                "        (and\r\n" +
                                "            (food-amount >= 25) ;food_amount skirmisher_line,\r\n" +
                                "            (wood-amount >= 410) ;wood_amount town_center, skirmisher_line, trade_cart,\r\n" +
                                "        )\r\n" +
                                "        (gold-amount >= 50) ;gold_amount trade_cart,\r\n" +
                                "    )\r\n" +
                                "    (stone-amount >= 100) ;stone_amount town_center,\r\n" +
                                ")";

            // Act
            var testClass = new  ResourceAmount(
                building.town_center,
                unit.skirmisher_line,
                unit.trade_cart);

            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ResourceAmountTestNoFoodGold()
        {
            // Arrange
            var expectedValue = "(and\r\n" +
                                "    (wood-amount >= 275) ;wood_amount town_center,\r\n" +
                                "    (stone-amount >= 100) ;stone_amount town_center,\r\n" +
                                ")";

            // Act
            var testClass = new  ResourceAmount(building.town_center);

            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ResourceAmountTestNoWoodStone()
        {
            // Arrange
            var expectedValue = "(and\r\n" +
                                "    (food-amount >= 60) ;food_amount knight,\r\n" +
                                "    (gold-amount >= 75) ;gold_amount knight,\r\n" +
                                ")";

            // Act
            var testClass = new  ResourceAmount(unit.knight);

            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ResourceAmountTestNullArg()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
            {
                _ = new  ResourceAmount(null);
            });
        }

        [TestMethod]
        public void ResourceAmountTestUnknownArg()
        {
            Assert.ThrowsException<KeyNotFoundException>(() =>
            {
                _ = new ResourceAmount(unit.unknown);
            });
        }
    }
}