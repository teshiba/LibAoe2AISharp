using LibAoe2AISharp.Specifications.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class TestEnterAgeTests
    {
        [TestMethod]
        public void EnterAgeTest()
        {
            // Arrange
            var expectedValue = ";Specifications.Tests.TestEnterAge\r\n" +
                                "(defrule\r\n" +
                                "    (true)\r\n" +
                                "=>\r\n" +
                                "    (set-goal AgeState Transitioned)\r\n" +
                                "    (disable-self)\r\n" +
                                ")\r\n";

            // Act
            var testClass = new TestEnterAge();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}