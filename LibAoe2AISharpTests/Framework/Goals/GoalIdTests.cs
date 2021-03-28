using System;
using System.Collections.ObjectModel;
using System.Reflection;
using LibAoe2AISharp.Specifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class GoalIdTests
    {
        [TestMethod]
        public void GoalIdTestComment()
        {
            // Arrange
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            typeof(GoalId).GetField("count", flag).SetValue(null, 0);
            typeof(GoalValue).GetField("count", flag).SetValue(null, 0);

            var expectedValue = "(defconst GoalId1 1) ;goal-id[1] goal id comment";

            // Act
            var testClass = new GoalId("GoalId1", "goal id comment");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void GoalIdTestConstantName()
        {
            // Arrange
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            typeof(GoalId).GetField("count", flag).SetValue(null, 0);
            typeof(GoalValue).GetField("count", flag).SetValue(null, 0);

            var expectedValue = "(defconst goalIdConstName 1) ;goal-id[1] goal id comment";

            // Act
            var testClass = new GoalId("goalIdConstName", "goal id comment");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void GoalIdTestGoalIdMaxException()
        {
            // Arrange
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            typeof(GoalId).GetField("count", flag).SetValue(null, 0);
            typeof(GoalValue).GetField("count", flag).SetValue(null, 0);

            Collection<GoalId> classList = new ();
            for (int i = 0; i < Limit.GoalIdMax; i++) {
                classList.Add(new GoalId("goalIdConstName", "goal id comment"));
            }

            // Act
            _ = Assert.ThrowsException<OverflowException>(() =>
              {
                  classList.Add(new GoalId("goalIdConstName", "goal id comment"));
              });
        }
    }
}