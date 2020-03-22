using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class BuildLumberCampTests
    {
        [TestMethod]
        public void BuildLumberCampTest()
        {
            // Arrange
            var expectedValue = ";Build lumber_camp Distance more than 10\r\n" +
                                "(defrule\r\n" +
                                "    (can-build lumber-camp) ;Can build lumber-camp?\r\n" +
                                "    (dropsite-min-distance wood >= 10) ; Distance 10 ge from wood\r\n" +
                                "=>\r\n" +
                                "    (build lumber-camp) ;Build lumber_camp\r\n" +
                                ")\r\n";

            // Act
            var testClass = new BuildLumberCamp {
                Distance = 10,
            };
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BuildLumberCampTest1()
        {
            // Arrange
            var expectedValue = ";Build lumber_camp up to 10.\r\n" +
                "(defrule\r\n" +
                "    (can-build lumber-camp) ;Can build lumber-camp?\r\n" +
                "    (building-type-count-total lumber-camp < 10) ;Count of lumber-camp\r\n" +
                "=>\r\n" +
                "    (build lumber-camp) ;Build lumber_camp\r\n" +
                ")\r\n";

            // Act
            var testClass = new BuildLumberCamp(10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}