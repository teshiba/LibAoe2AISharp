using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class BuildMiningCampTests
    {
        [TestMethod]
        public void BuildMiningCampTest()
        {
            // Arrange
            var expectedValue = ";Build mining_camp\r\n" +
                "(defrule\r\n" +
                "    (can-build mining-camp) ;Can build mining-camp?\r\n" +
                "=>\r\n" +
                "    (build mining-camp) ;Build mining_camp\r\n" +
                ")\r\n";

            // Act
            var testClass = new BuildMiningCamp();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BuildMiningCampTest1()
        {
            // Arrange
            var expectedValue = ";Build mining_camp up to 10. Distance more than 20\r\n" +
                                "(defrule\r\n" +
                                "    (can-build mining-camp) ;Can build mining-camp?\r\n" +
                                "    (building-type-count-total mining-camp < 10) ;Count of mining-camp\r\n" +
                                "    (or\r\n" +
                                "        (dropsite-min-distance gold >= 20) ; Distance 20 ge from gold\r\n" +
                                "        (dropsite-min-distance stone >= 20) ; Distance 20 ge from stone\r\n" +
                                "    )\r\n" +
                                "=>\r\n" +
                                "    (build mining-camp) ;Build mining_camp\r\n" +
                                ")\r\n";

            // Act
            var testClass = new BuildMiningCamp(10) {
                Distance = 20,
            };

            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}