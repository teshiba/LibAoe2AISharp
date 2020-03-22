using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class sheep_and_forage_too_farTests
    {
        [TestMethod]
        public void sheep_and_forage_too_farTest()
        {
            // Arrange
            var expectedValue = "(sheep-and-forage-too-far)";

            // Act
            var testClass = new sheep_and_forage_too_far();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}