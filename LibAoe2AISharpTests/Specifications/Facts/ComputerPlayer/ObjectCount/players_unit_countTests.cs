using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class players_unit_countTests
    {
        [TestMethod]
        public void players_unit_countTest()
        {
            // Arrange
            var expectedValue = "(players-unit-count any-computer-enemy == 10)";

            // Act
            var testClass = new players_unit_count(
                player_number.any_computer_enemy, relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}