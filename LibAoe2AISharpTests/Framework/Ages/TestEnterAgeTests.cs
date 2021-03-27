using System;

using LibAoe2AISharp.Specifications.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class TestEnterAgeTests
    {
        [TestMethod]
        public void EnterAgeTest()
        {
            // Arrange
            var expectedValue = ";Specifications.Tests.TestEnterAge" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (true)" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (set-goal AgeState Transitioned)" + Environment.NewLine +
                                "    (disable-self)" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new TestEnterAge();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}