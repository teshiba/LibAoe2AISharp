using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class BuildHouseTests
    {
        [TestMethod]
        public void BuildHouseTest()
        {
            // Arrange
            var expectedValue = ";Build house\r\n" +
                "(defrule\r\n" +
                "    (can-build house) ;Can build house?\r\n" +
                "=>\r\n" +
                "    (build house) ;Build house\r\n" +
                ")\r\n";

            // Act
            var testClass = new BuildHouse();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BuildHouseTestRemain()
        {
            // Arrange
            var expectedValue = ";Build house remaining capacity less than 10\r\n" +
                "(defrule\r\n" +
                "    (can-build house) ;Can build house?\r\n" +
                "    (housing-headroom <= 10) ;checks remaining populations capacity\r\n" +
                "=>\r\n" +
                "    (build house) ;Build house\r\n" +
                ")\r\n";

            // Act
            var testClass = new BuildHouse(10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}