using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class SetGathererRateCollectionTests
    {
        [TestMethod]
        public void SetGathererRateCollectionTest()
        {
            // Arrange
            var expectedValue = "    (set-strategic-number sn-food-gatherer-percentage 10) ;food_gatherer_percentage" + Environment.NewLine +
                                "    (set-strategic-number sn-wood-gatherer-percentage 20) ;wood_gatherer_percentage" + Environment.NewLine +
                                "    (set-strategic-number sn-gold-gatherer-percentage 30) ;gold_gatherer_percentage" + Environment.NewLine +
                                "    (set-strategic-number sn-stone-gatherer-percentage 40) ;stone_gatherer_percentage" + Environment.NewLine;

            // Act
            var testClass = new SetGathererRateCollection(10, 20, 30, 40);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void SetGathererRateCollectionTestGathererNumberArg()
        {
            // Arrange
            var expectedValue = "    (set-strategic-number sn-food-gatherer-percentage 10) ;food_gatherer_percentage" + Environment.NewLine +
                                "    (set-strategic-number sn-wood-gatherer-percentage 20) ;wood_gatherer_percentage" + Environment.NewLine +
                                "    (set-strategic-number sn-gold-gatherer-percentage 30) ;gold_gatherer_percentage" + Environment.NewLine +
                                "    (set-strategic-number sn-stone-gatherer-percentage 40) ;stone_gatherer_percentage" + Environment.NewLine;

            // Act
            var testClass = new SetGathererRateCollection(new GathererRate(10, 20, 30, 40));
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void SetGathererRateCollectionTestArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                _ = new SetGathererRateCollection(null);
            });
        }
    }
}