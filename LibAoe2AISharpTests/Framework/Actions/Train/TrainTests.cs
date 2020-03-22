using LibAoe2AISharp.Specifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class TrainTests
    {
        [TestMethod]
        public void TrainTest()
        {
            // Arrange
            var expectedValue = ";Train archer\r\n" +
                                "(defrule\r\n" +
                                "    (can-train archer) ;Can train archer?\r\n" +
                                "=>\r\n" +
                                "    (train archer) ;Train archer\r\n" +
                                ")\r\n";

            // Act
            var testClass = new Train(unit.archer);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TrainTestCount()
        {
            // Arrange
            var expectedValue = ";Train archer up to 10\r\n" +
                                "(defrule\r\n" +
                                "    (can-train archer) ;Can train archer?\r\n" +
                                "    (unit-type-count-total archer < 10) ;Check count : unit archer\r\n" +
                                "=>\r\n" +
                                "    (train archer) ;Train archer\r\n" +
                                ")\r\n";

            // Act
            var testClass = new Train(unit.archer, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}