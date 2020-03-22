using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class set_strategic_numberTests
    {
        [TestMethod]
        public void set_strategic_numberTest()
        {
            // Arrange
            var expectedValue = "(set-strategic-number sn-attack-diplomacy-impact 10) ;attack_diplomacy_impact";

            // Act
            var testClass = new set_strategic_number(sn.attack_diplomacy_impact, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}