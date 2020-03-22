using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class BuildMillTests
    {
        [TestMethod]
        public void BuildMillTest()
        {
            // Arrange
            var expectedValue = ";Build mill\r\n" +
                                "(defrule\r\n" +
                                "    (can-build mill) ;Can build mill?\r\n" +
                                "=>\r\n" +
                                "    (build mill) ;Build mill\r\n" +
                                ")\r\n";

            // Act
            var testClass = new BuildMill();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BuildMillTestCount()
        {
            // Arrange
            var expectedValue = ";Build mill up to 10. Distance more than 10\r\n" +
                                "(defrule\r\n" +
                                "    (can-build mill) ;Can build mill?\r\n" +
                                "    (building-type-count-total mill < 10) ;Count of mill\r\n" +
                                "    (dropsite-min-distance food >= 10) ; Distance 10 ge from food\r\n" +
                                "=>\r\n" +
                                "    (build mill) ;Build mill\r\n" +
                                ")\r\n";

            // Act
            var testClass = new BuildMill(10) {
                Distance = 10,
            };

            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}