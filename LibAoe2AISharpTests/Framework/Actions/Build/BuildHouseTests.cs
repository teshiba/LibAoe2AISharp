using System;
using System.Xml;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class BuildHouseTests
    {
        [TestMethod]
        public void BuildHouseTest()
        {
            // Arrange
            var expectedValue = ";Build house" + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (can-build house) ;Can build house?" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (build house) ;Build house" + Environment.NewLine +
                ")" + Environment.NewLine;

            // Act
            var testClass = new BuildHouse();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BuildHouseTestRemain()
        {
            // Arrange
            var expectedValue = ";Build house remaining capacity less than 10" + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (can-build house) ;Can build house?" + Environment.NewLine +
                "    (housing-headroom <= 10) ;checks remaining populations capacity" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (build house) ;Build house" + Environment.NewLine +
                ")" + Environment.NewLine;

            // Act
            var testClass = new BuildHouse(10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}