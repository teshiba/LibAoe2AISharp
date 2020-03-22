using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class buildTests
    {
        [TestMethod]
        public void buildTest()
        {
            // Arrange
            var expectedValue = "(build archery-range) ;Build archery_range";

            // Act
            var testClass = new build(building.archery_range);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}