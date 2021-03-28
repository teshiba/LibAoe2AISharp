using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class GathererRateTests
    {
        [TestMethod]
        public void GathererRateTest()
        {
            // Arrange

            // Act
            var testClass = new GathererRate(10, 20, 30, 40);
            var actualValue = testClass;

            // Assert
            Assert.AreEqual(0, actualValue.Total);
            Assert.AreEqual(10, actualValue.Food);
            Assert.AreEqual(20, actualValue.Wood);
            Assert.AreEqual(30, actualValue.Gold);
            Assert.AreEqual(40, actualValue.Stone);
            Assert.AreEqual("%", actualValue.Unit);
            Assert.AreEqual(true, actualValue.UnitPercentage);
        }

        [TestMethod]
        public void GathererRateTestAtLeastOneZeroArguments()
        {
            // Arrange

            // Act
            var testClass = new GathererRate(new GathererNumber(100, 25, 35, 40, 0));
            var actualValue = testClass;

            // Assert
            Assert.AreEqual(0, actualValue.Total);
            Assert.AreEqual(25, actualValue.Food);
            Assert.AreEqual(35, actualValue.Wood);
            Assert.AreEqual(40, actualValue.Gold);
            Assert.AreEqual(0, actualValue.Stone);
            Assert.AreEqual("%", actualValue.Unit);
            Assert.AreEqual(true, actualValue.UnitPercentage);
        }

        [TestMethod]
        public void GathererRateTestGathererNumber()
        {
            // Arrange

            // Act
            var testClass = new GathererRate(new GathererNumber(100, 10, 20, 30, 40));
            var actualValue = testClass;

            // Assert
            Assert.AreEqual(0, actualValue.Total);
            Assert.AreEqual(10, actualValue.Food);
            Assert.AreEqual(20, actualValue.Wood);
            Assert.AreEqual(30, actualValue.Gold);
            Assert.AreEqual(40, actualValue.Stone);
            Assert.AreEqual("%", actualValue.Unit);
            Assert.AreEqual(true, actualValue.UnitPercentage);
        }

        [TestMethod]
        public void GathererRateTestArgumentNullException()
        {
            _ = Assert.ThrowsException<ArgumentNullException>(() =>
            {
                _ = new GathererRate(null);
            });
        }
    }
}