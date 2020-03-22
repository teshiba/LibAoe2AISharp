using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class unit_type_countTests
    {
        [TestMethod]
        public void unit_type_countTest()
        {
            // Arrange
            var expectedValue = 100;
            var expectedOpe = relop.ge;
            var expectedUnit = unit.archer;

            // Act
            var testClass = new unit_type_count(expectedUnit, expectedOpe, expectedValue);
            var actualValue = testClass.Value;
            var actualOpe = testClass.Ope;
            var actualUnit = (unit)testClass.Operand;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedOpe, actualOpe);
            Assert.AreEqual(expectedUnit, actualUnit);
        }
    }
}