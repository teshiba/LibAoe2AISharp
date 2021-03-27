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

            var expectedValue = ";Research castle_age" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-research castle-age) ;Can research castle-age?" + Environment.NewLine +
                                "    (current-age == feudal-age) ;Check feudal-age" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (research castle-age) ;Research castle_age" + Environment.NewLine +
                                "    (set-goal AgeState Transitioning)" + Environment.NewLine +
                                ")" + Environment.NewLine;

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

            var expectedValue = ";Research castle_age" + Environment.NewLine +
            "(defrule" + Environment.NewLine +
                     "    (can-research castle-age) ;Can research castle-age?" + Environment.NewLine +
                     "    (current-age == feudal-age) ;Check feudal-age" + Environment.NewLine +
                     "    (unit-type-count villager >= 100) ;Check count : unit villager" + Environment.NewLine +
                     "=>" + Environment.NewLine +
                     "    (research castle-age) ;Research castle_age" + Environment.NewLine +
                     "    (set-goal AgeState Transitioning)" + Environment.NewLine +
                     ")" + Environment.NewLine;

            // Act
            var testClass = new ResearchAge(age.castle_age, 100);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}