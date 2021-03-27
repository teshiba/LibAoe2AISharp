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
            var expectedValue = "(and" + Environment.NewLine +
                                "    (and" + Environment.NewLine +
                                "        (and" + Environment.NewLine +
                                "            (food-amount >= 25) ;food_amount skirmisher_line," + Environment.NewLine +
                                "            (wood-amount >= 410) ;wood_amount town_center, skirmisher_line, trade_cart," + Environment.NewLine +
                                "        )" + Environment.NewLine +
                                "        (gold-amount >= 50) ;gold_amount trade_cart," + Environment.NewLine +
                                "    )" + Environment.NewLine +
                                "    (stone-amount >= 100) ;stone_amount town_center," + Environment.NewLine +
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
            var expectedValue = "(and" + Environment.NewLine +
                                "    (wood-amount >= 275) ;wood_amount town_center," + Environment.NewLine +
                                "    (stone-amount >= 100) ;stone_amount town_center," + Environment.NewLine +
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
            var expectedValue = "(and" + Environment.NewLine +
                                "    (food-amount >= 60) ;food_amount knight," + Environment.NewLine +
                                "    (gold-amount >= 75) ;gold_amount knight," + Environment.NewLine +
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