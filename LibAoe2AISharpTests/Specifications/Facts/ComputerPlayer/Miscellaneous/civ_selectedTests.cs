using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class civ_selectedTests
    {
        [TestMethod]
        public void civ_selectedTest()
        {
            // Arrange
            var expectedValue = "(civ-selected aztec)";

            // Act
            var testClass = new civ_selected(civ.aztec);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}