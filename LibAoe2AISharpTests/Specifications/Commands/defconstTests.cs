using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class defconstTests
    {
        [TestMethod]
        public void defconstTestException()
        {
            _ = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                // constantName needs strings without space.
                _ = new defconst("test constant name", 1);
            });
        }

        [TestMethod]
        public void defconstTest()
        {
            // Arrange
            int constValue = 1;
            var expectedValue = constValue;

            // Act
            var testConst = new defconst(constValue);

            // Assert
            Assert.AreEqual("defconst", testConst.Comment);
            Assert.AreEqual(null, testConst.ConstantName);
            Assert.AreEqual(expectedValue, testConst.Value);
        }

        [TestMethod]
        public void defconstTest1()
        {
            // Arrange
            int constValue = 1;
            var constName = "CONSTNAME";
            string expectedConstantName = constName;
            var expectedValue = constValue;

            // Act
            var testConst = new defconst(constName, constValue);

            // Assert
            Assert.AreEqual(null, testConst.Comment);
            Assert.AreEqual(expectedConstantName, testConst.ConstantName);
            Assert.AreEqual(expectedValue, testConst.Value);
        }

        [TestMethod]
        public void defconstTest2()
        {
            // Arrange
            int constValue = 1;
            var expectedComment = "defconst user comment";
            var expectedValue = constValue;

            // Act
            var testConst = new defconst(constValue, expectedComment);

            // Assert
            Assert.AreEqual(expectedComment, testConst.Comment);
            Assert.AreEqual(null, testConst.ConstantName);
            Assert.AreEqual(expectedValue, testConst.Value);
        }

        [TestMethod]
        public void defconstTest3()
        {
            // Arrange
            var expectedComment = "UserDefconst";
            var expectedValue = 0;

            // Act
            var testConst = new UserDefconst();

            // Assert
            Assert.AreEqual(expectedComment, testConst.Comment);
            Assert.AreEqual(null, testConst.ConstantName);
            Assert.AreEqual(expectedValue, testConst.Value);
        }

        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var testConst1 = new UserDefconst();
            var testConst2 = new defconst(1);
            var testConst3 = new defconst(1, "comment");
            var testConst4 = new defconst("constName", 1);
            var testConst5 = new defconst("constName", 1, "comment");

            // Act
            var script1 = testConst1.ToScript();
            var script2 = testConst2.ToScript();
            var script3 = testConst3.ToScript();
            var script4 = testConst4.ToScript();
            var script5 = testConst5.ToScript();

            // Assert
            Assert.AreEqual("(defconst UserDefconst 0) ;UserDefconst", script1);
            Assert.AreEqual("(defconst defconst 1) ;defconst", script2);
            Assert.AreEqual("(defconst defconst 1) ;comment", script3);
            Assert.AreEqual("(defconst constName 1)", script4);
            Assert.AreEqual("(defconst constName 1) ;comment", script5);
        }

        [TestMethod]
        public void ToScriptTest1()
        {
            // Arrange
            var testConst1 = new defconst("constName", 1, "comment");

            // Act
            var script1 = testConst1.ToScript(2);

            // Assert
            Assert.AreEqual("        (defconst constName 1) ;comment", script1);
        }
    }
}