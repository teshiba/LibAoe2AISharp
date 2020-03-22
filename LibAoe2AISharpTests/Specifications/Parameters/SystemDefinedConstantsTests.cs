using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class SystemDefinedConstantsTests
    {
        [TestMethod]
        public void IsSystemDefinedConstTest()
        {
            // Arrange

            // Act
            var actualValueTrue = player_number.my_player_number.IsSystemDefinedConst();
            var actualValueFalse = unit.arbalest.IsSystemDefinedConst();

            // Assert
            Assert.AreEqual(true, actualValueTrue);
            Assert.AreEqual(false, actualValueFalse);
        }

        [TestMethod]
        public void IsSystemDefinedConstTestNull()
        {
            // Arrange

            // Act
            var actualValue1 = ResearchItem.IsSystemDefinedConst(null);

            // Assert
            Assert.AreEqual(false, actualValue1);
        }
    }
}