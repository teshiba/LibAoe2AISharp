using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class town_under_attackTests
    {
        [TestMethod]
        public void town_under_attackTest()
        {
            // Arrange
            var expectedValue = "(town-under-attack)";

            // Act
            var testClass = new town_under_attack();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}