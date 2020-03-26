using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class player_in_gameTests
    {
        [TestMethod]
        public void player_in_gameTest()
        {
            // Arrange
            var expectedValue = "(player-in-game any-computer-enemy)";

            // Act
            var testClass = new player_in_game(player_number.any_computer_enemy);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}