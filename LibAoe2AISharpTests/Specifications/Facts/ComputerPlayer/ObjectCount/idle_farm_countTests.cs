using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class idle_farm_countTests
    {
        [TestMethod]
        public void idle_farm_countTest()
        {
            // Arrange
            var expectedValue = "(idle-farm-count == 10) ;Idle farm count eq 10";

            // Act
            var testClass = new idle_farm_count(Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}