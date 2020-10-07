using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarReHuntingTests
    {
        [TestMethod()]
        public void BoarReHuntingTest()
        {
            // Arrange
            var expVal = 
                ";Boar is exsist\r\n" + 
                "(defrule\r\n" + 
                "    (goal BoarState BoarEating)\r\n" + 
                "    (not (dropsite-min-distance live-boar <= 12)) ; Distance 12 le from live-boar\r\n" + 
                "    (dropsite-min-distance live-boar >= 12) ; Distance 12 ge from live-boar\r\n" + 
                "=>\r\n" + 
                "    (set-strategic-number sn-maximum-hunt-drop-distance 32) ;maximum_hunt_drop_distance\r\n" + 
                "    (set-goal BoarState Boarluring)\r\n" + 
                ")\r\n";

            // Act
            var testClass = new BoarReHunting(12, 32);
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}