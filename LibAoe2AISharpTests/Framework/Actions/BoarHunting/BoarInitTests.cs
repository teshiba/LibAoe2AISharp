using System;

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
                ";Framework.BoarInit" + Environment.NewLine + 
                "(defrule" + Environment.NewLine + 
                "    (true)" + Environment.NewLine + 
                "=>" + Environment.NewLine + 
                "    (set-goal BoarState BoarInit)" + Environment.NewLine + 
                "    (disable-self)" + Environment.NewLine + 
                ")" + Environment.NewLine;

            // Act
            var testClass = new BoarInit();
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}