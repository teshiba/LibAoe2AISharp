using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class current_ageTests
    {
        [TestMethod]
        public void current_ageTest()
        {
            // Arrange
            var expectedValue = "(current-age == castle-age) ;Check castle_age";

            // Act
            var testClass = new current_age(Ope.relop.eq, age.castle_age);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}