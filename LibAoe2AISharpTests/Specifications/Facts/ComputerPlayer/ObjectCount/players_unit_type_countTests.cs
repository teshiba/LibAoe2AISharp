using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class players_unit_type_countTests
    {
        [TestMethod]
        public void players_unit_type_countTest()
        {
            // Arrange
            var expectedValue = "(players-unit-type-count any-computer-enemy archer == 20)";

            // Act
            var testClass = new players_unit_type_count(
                player_number.any_computer_enemy, unit.archer, relop.eq, 20);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}