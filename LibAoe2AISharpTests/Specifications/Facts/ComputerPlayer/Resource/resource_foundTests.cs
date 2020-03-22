using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class resource_foundTests
    {
        [TestMethod]
        public void resource_foundTest()
        {
            // Arrange
            var expectedValue = "(resource-found food)";

            // Act
            var testClass = new resource_found(resource_type.food);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}