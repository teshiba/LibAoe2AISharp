using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarInitTests
    {
        [TestMethod()]
        public void BoarInitTest()
        {
            // Arrange
            var expVal = 
                ";Framework.BoarInit\r\n" + 
                "(defrule\r\n" + 
                "    (true)\r\n" + 
                "=>\r\n" + 
                "    (set-goal BoarState BoarInit)\r\n" + 
                "    (disable-self)\r\n" + 
                ")\r\n";

            // Act
            var testClass = new BoarInit();
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}