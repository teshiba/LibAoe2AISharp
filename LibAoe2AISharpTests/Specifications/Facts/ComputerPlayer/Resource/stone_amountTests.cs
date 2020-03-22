using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class stone_amountTests
    {
        [TestMethod]
        public void stone_amountTest()
        {
            // Arrange
            var expectedValue = "(stone-amount == 10) ;stone_amount";

            // Act
            var testClass = new stone_amount(Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}