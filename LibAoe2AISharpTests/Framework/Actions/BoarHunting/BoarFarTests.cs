using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarFarTests
    {
        [TestMethod()]
        public void BoarFarTest()
        {
            // Arrange
            var expVal =
                ";Boar is far. Then stop hunting.\r\n" +
                "(defrule\r\n" +
                "    (goal BoarState BoarEating)\r\n" +
                "    (dropsite-min-distance live-boar >= 30) ; Distance 30 ge from live-boar\r\n" +
                "=>\r\n" +
                "    (set-goal BoarState BoarEnd)\r\n" +
                "    (set-strategic-number sn-enable-boar-hunting 1) ;enable_boar_hunting\r\n" +
                "    (set-strategic-number sn-minimum-number-hunters 0) ;minimum_number_hunters\r\n" +
                ")\r\n";

            // Act
            var testClass = new BoarFar(30);
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}