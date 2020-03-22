using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class can_trainTests
    {
        [TestMethod]
        public void can_trainTest()
        {
            // Arrange
            var expectedValue = "(can-train archer) ;Can train archer?";

            // Act
            var testClass = new can_train(unit.archer);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}