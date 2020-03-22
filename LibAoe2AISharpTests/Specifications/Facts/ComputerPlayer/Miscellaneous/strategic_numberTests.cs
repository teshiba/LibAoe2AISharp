using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class strategic_numberTests
    {
        [TestMethod]
        public void strategic_numberTest()
        {
            // Arrange
            var expectedValue = "(strategic-number sn-attack-diplomacy-impact == 1)";

            // Act
            var testClass = new strategic_number(sn.attack_diplomacy_impact, relop.eq, 1);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}