using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class InitGoalIdTests
    {
        [TestMethod]
        public void InitGoalIdTest()
        {
            // Arrange
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            typeof(GoalId).GetField("count", flag).SetValue(null, 0);
            typeof(GoalValue).GetField("count", flag).SetValue(null, 0);

            var expectedValue = ";Initalize goal ID parameters\r\n" +
                                "(defrule\r\n" +
                                "    (true)\r\n" +
                                "=>\r\n" +
                                "    (set-goal AgeState Transitioned)\r\n" +
                                "    (disable-self)\r\n" +
                                ")\r\n";

            // Act
            var testClass = new InitGoalId();

            // Assert
            Assert.AreEqual("(set-goal AgeState Transitioned)", testClass.Actions[0].ToScript());
            Assert.AreEqual("(disable-self)", testClass.Actions[1].ToScript());
            Assert.AreEqual("Initalize goal ID parameters", testClass.Comment);
            Assert.AreEqual(string.Empty, testClass.DebugActions.ToScript("InitGoalId", testClass.Comment));
            Assert.AreEqual("(true)" + Environment.NewLine, testClass.Facts.ToScript());
            Assert.AreEqual(expectedValue, testClass.ToScript());
        }
    }
}