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
            var expVal = "(defconst BoarTestState 0) ;goal-id value[0] [Boar]test comment";

            // Act
            var testClass = new BoarGoal("TestState", "test comment");
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}