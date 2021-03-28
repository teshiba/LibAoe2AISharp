using System.Reflection;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarGoalTests
    {

        [TestMethod()]
        public void BoarGoalTest()
        {
            // Arrange
            var bindingAttr = BindingFlags.NonPublic | BindingFlags.Static;
            var goalVal = (int)typeof(BoarGoal).GetField("count", bindingAttr).GetValue(null);
            var expVal = $"(defconst BoarTestState {goalVal}) ;goal-id value[{goalVal}] [Boar]test comment";

            // Act
            var testClass = new BoarGoal("TestState", "test comment");
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}