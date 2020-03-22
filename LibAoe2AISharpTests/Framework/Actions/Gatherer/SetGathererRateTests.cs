using System;
using LibAoe2AISharp.Specifications.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class SetGathererRateTests
    {
        [TestMethod]
        public void SetGathererRateTestCount1()
        {
            // Arrange
            string expectedValue =  ";[total:100 F50, W30, G10, S10]:set gatherer rate comment\r\n" +
                                    "(defrule\r\n" +
                                    "    (unit-type-count villager == 100) ;Check count : unit villager\r\n" +
                                    "    (TestAIFact testAIFactParam)\r\n" +
                                    "=>\r\n" +
                                    "    (set-strategic-number sn-food-gatherer-percentage 50) ;food_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-wood-gatherer-percentage 30) ;wood_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-gold-gatherer-percentage 10) ;gold_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-stone-gatherer-percentage 10) ;stone_gatherer_percentage\r\n" +
                                    "    (disable-self)\r\n" +
                                    ")\r\n";

            // Act
            var testClass = new SetGathererRate(100, 50, 30, 10, 10, new TestAIFact(), "set gatherer rate comment");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void SetGathererRateTestCount2()
        {
            // Arrange
            string expectedValue =  ";[total:100 F50, W30, G10, S10]\r\n" +
                                    "(defrule\r\n" +
                                    "    (unit-type-count villager == 100) ;Check count : unit villager\r\n" +
                                    "=>\r\n" +
                                    "    (set-strategic-number sn-food-gatherer-percentage 50) ;food_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-wood-gatherer-percentage 30) ;wood_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-gold-gatherer-percentage 10) ;gold_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-stone-gatherer-percentage 10) ;stone_gatherer_percentage\r\n" +
                                    "    (disable-self)\r\n" +
                                    ")\r\n";

            // Act
            var testClass = new SetGathererRate(100, 50, 30, 10, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void SetGathererRateTestCount3()
        {
            // Arrange
            string expectedValue =  ";[total:100 F50, W30, G10, S10]\r\n" +
                                    "(defrule\r\n" +
                                    "    (unit-type-count villager == 100) ;Check count : unit villager\r\n" +
                                    "    (TestAIFact testAIFactParam)\r\n" +
                                    "=>\r\n" +
                                    "    (set-strategic-number sn-food-gatherer-percentage 50) ;food_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-wood-gatherer-percentage 30) ;wood_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-gold-gatherer-percentage 10) ;gold_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-stone-gatherer-percentage 10) ;stone_gatherer_percentage\r\n" +
                                    "    (disable-self)\r\n" +
                                    ")\r\n";

            // Act
            var testClass = new SetGathererRate(100, 50, 30, 10, 10, new TestAIFact());
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void SetGathererRateTestPercent1()
        {
            // Arrange
            string expectedValue =  ";[% F50, W30, G10, S10]:set gatherer rate comment\r\n" +
                                    "(defrule\r\n" +
                                    "    (TestAIFact testAIFactParam)\r\n" +
                                    "=>\r\n" +
                                    "    (set-strategic-number sn-food-gatherer-percentage 50) ;food_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-wood-gatherer-percentage 30) ;wood_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-gold-gatherer-percentage 10) ;gold_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-stone-gatherer-percentage 10) ;stone_gatherer_percentage\r\n" +
                                    "    (disable-self)\r\n" +
                                    ")\r\n";

            // Act
            var testClass = new SetGathererRate(50, 30, 10, 10, new TestAIFact(), "set gatherer rate comment");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void SetGathererRateTestPercent2()
        {
            // Arrange
            string expectedValue =  ";[% F50, W30, G10, S10]\r\n" +
                                    "(defrule\r\n" +
                                    "    (TestAIFact testAIFactParam)\r\n" +
                                    "=>\r\n" +
                                    "    (set-strategic-number sn-food-gatherer-percentage 50) ;food_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-wood-gatherer-percentage 30) ;wood_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-gold-gatherer-percentage 10) ;gold_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-stone-gatherer-percentage 10) ;stone_gatherer_percentage\r\n" +
                                    "    (disable-self)\r\n" +
                                    ")\r\n";

            // Act
            var testClass = new SetGathererRate(50, 30, 10, 10, new TestAIFact());
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void SetGathererRateTestPercent3()
        {
            // Arrange
            string expectedValue =  ";[% F50, W30, G10, S10]\r\n" +
                                    "(defrule\r\n" +
                                    "    (true)\r\n" +
                                    "=>\r\n" +
                                    "    (set-strategic-number sn-food-gatherer-percentage 50) ;food_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-wood-gatherer-percentage 30) ;wood_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-gold-gatherer-percentage 10) ;gold_gatherer_percentage\r\n" +
                                    "    (set-strategic-number sn-stone-gatherer-percentage 10) ;stone_gatherer_percentage\r\n" +
                                    "    (disable-self)\r\n" +
                                    ")\r\n";

            // Act
            var testClass = new SetGathererRate(50, 30, 10, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void SetGathererRateArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                _ = new SetGathererRate(null, null, string.Empty);
            });
        }
    }
}