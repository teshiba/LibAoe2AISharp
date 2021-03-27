using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class GoalTests
    {
        [TestMethod]
        public void GoalTest()
        {
            // Arrange
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            typeof(GoalId).GetField("count", flag).SetValue(null, 0);
            typeof(GoalValue).GetField("count", flag).SetValue(null, 0);

            var testGoal = new GoalId("GoalId1", "testGoalId");
            var value1 = new TestGoalValue("TestGoalValue1", "testGoalIdValue");
            var expectedValue = "(goal GoalId1 TestGoalValue1) ;goal comment";

            // Act
            var testClass = new goal(testGoal, value1) {
                Comment = "goal comment",
            };

            // Assert
            Assert.AreEqual("goal comment", testClass.Comment);
            Assert.AreEqual(expectedValue, testClass.ToScript());
        }
    }
}