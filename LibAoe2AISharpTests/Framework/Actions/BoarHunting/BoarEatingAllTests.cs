using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarEatingAllTests
    {
        [TestMethod()]
        public void BoarEatingAllTest()
        {
            // Arrange
            var expVal = ";Boar nothing\r\n" +
                         "(defrule\r\n" +
                         "    (goal BoarState BoarEating)\r\n" +
                         "    (not (dropsite-min-distance live-boar <= 32)) ; Distance 32 le from live-boar\r\n" +
                         "    (unit-type-count villager-hunter == 0) ;Check count : unit villager-hunter\r\n" +
                         "=>\r\n" +
                         "    (set-goal BoarState BoarEnd)\r\n" +
                         "    (set-strategic-number sn-enable-boar-hunting 1) ;enable_boar_hunting\r\n" +
                         "    (set-strategic-number sn-minimum-number-hunters 0) ;minimum_number_hunters\r\n" +
                         ")\r\n";

            // Act
            var testClass = new BoarEatingAll(32);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actualValue);
        }
    }
}