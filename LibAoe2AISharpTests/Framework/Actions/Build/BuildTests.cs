using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class BuildTests
    {
        [TestMethod]
        public void BuildTest()
        {
            // Arrange
            var expectedValue = string.Empty;
            expectedValue += ";Build archery_range\r\n";
            expectedValue += "(defrule\r\n";
            expectedValue += "    (can-build archery-range) ;Can build archery-range?\r\n";
            expectedValue += "=>\r\n";
            expectedValue += "    (build archery-range) ;Build archery_range\r\n";
            expectedValue += ")\r\n";

            // Act
            var testClass = new Build(Specifications.building.archery_range);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BuildTest1()
        {
            // Arrange
            var expectedValue = string.Empty;
            expectedValue += ";Build archery_range up to 10.\r\n";
            expectedValue += "(defrule\r\n";
            expectedValue += "    (can-build archery-range) ;Can build archery-range?\r\n";
            expectedValue += "    (building-type-count-total archery-range < 10) ;Count of archery-range\r\n";
            expectedValue += "=>\r\n";
            expectedValue += "    (build archery-range) ;Build archery_range\r\n";
            expectedValue += ")\r\n";

            // Act
            var testClass = new Build(Specifications.building.archery_range, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}