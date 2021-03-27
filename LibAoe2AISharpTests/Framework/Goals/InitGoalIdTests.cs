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

            var expectedValue = ";Initialize goal ID parameters" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (true)" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (set-goal AgeState Transitioned)" + Environment.NewLine +
                                "    (disable-self)" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new InitGoalId();

            // Assert
            Assert.AreEqual("(set-goal AgeState Transitioned)", testClass.Actions[0].ToScript());
            Assert.AreEqual("(disable-self)", testClass.Actions[1].ToScript());
            Assert.AreEqual("Initialize goal ID parameters", testClass.Comment);
            Assert.AreEqual(string.Empty, testClass.DebugActions.ToScript("InitGoalId", testClass.Comment));
            Assert.AreEqual("(true)" + Environment.NewLine, testClass.Facts.ToScript());
            Assert.AreEqual(expectedValue, testClass.ToScript());
        }
    }
}