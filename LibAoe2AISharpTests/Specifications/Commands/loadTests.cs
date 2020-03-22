using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class loadTests
    {
        [TestMethod]
        public void loadTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _ = new load("file name contained space is trhow exception");
            });
        }

        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var expectedValue = @"(load ""testFile"")";

            // Act
            var testClass = new load("testFile");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ToScriptTest1()
        {
            // Arrange
            var expectedValue = @"        (load ""testFile"") ;load command comment";

            // Act
            var testClass = new load("testFile"){Comment = "load command comment" };
            var actualValue = testClass.ToScript(2);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}