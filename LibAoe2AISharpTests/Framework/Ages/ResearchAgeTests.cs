using System;
using System.Reflection;
using LibAoe2AISharp.Specifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class ResearchAgeTests
    {
        [TestMethod]
        public void ResearchAgeTest()
        {
            // Arrange
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            typeof(GoalId).GetField("count", flag).SetValue(null, 0);
            typeof(GoalValue).GetField("count", flag).SetValue(null, 0);

            var expectedValue = ";Research castle_age\r\n" +
                                "(defrule\r\n" +
                                "    (can-research castle-age) ;Can research castle-age?\r\n" +
                                "    (current-age == feudal-age) ;Check feudal-age\r\n" +
                                "=>\r\n" +
                                "    (research castle-age) ;Research castle_age\r\n" +
                                "    (set-goal AgeState Transitioning)\r\n" +
                                ")\r\n";

            // Act
            var testClass = new ResearchAge(age.castle_age);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ResearchAgeTestArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _ = new ResearchAge(age.dark_age);
            });

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _ = new ResearchAge(age.dark_age - 1);
            });
        }

        [TestMethod]
        public void ResearchAgeTestPopulation()
        {
            // Arrange
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            typeof(GoalId).GetField("count", flag).SetValue(null, 0);
            typeof(GoalValue).GetField("count", flag).SetValue(null, 0);

            var expectedValue = ";Research castle_age\r\n" +
            "(defrule\r\n" +
                     "    (can-research castle-age) ;Can research castle-age?\r\n" +
                     "    (current-age == feudal-age) ;Check feudal-age\r\n" +
                     "    (unit-type-count villager >= 100) ;Check count : unit villager\r\n" +
                     "=>\r\n" +
                     "    (research castle-age) ;Research castle_age\r\n" +
                     "    (set-goal AgeState Transitioning)\r\n" +
                     ")\r\n";

            // Act
            var testClass = new ResearchAge(age.castle_age, 100);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}