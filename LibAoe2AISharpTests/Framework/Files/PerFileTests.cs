﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class PerFileTests
    {
        [TestMethod]
        public void FileNameTestWithoutPathName()
        {
            // Arrange
            var expectedValue = "TestPerFile";

            // Act
            var testClass = new TestPerFile();
            var actualValue = testClass.FileName;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FileNameTestWithPathName()
        {
            // Arrange
            var expectedValue = "TestPerFileTestPerFile";

            // Act
            var testClass = new TestPerFile(){
                ParentFile = new TestPerFile(){
                },
            };
            var actualValue = testClass.FileName;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ParentFileTest()
        {
            // Arrange
            var expectedValue = new TestPerFile();

            // Act
            var testClass = new TestPerFile() {
                ParentFile = expectedValue,
            };

            // Assert
            Assert.AreEqual(expectedValue, testClass.ParentFile);
        }

        [TestMethod]
        public void ParentFileSetSelfFiel()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                var testClass = new TestPerFile();
                testClass.ParentFile = testClass;
            });
        }

        [TestMethod]
        public void OutputScriptTest()
        {
            // Arrange
            var expectedOutputScript = ";Age of Empires II Computer Player Strategy\r\n" +
                ";Generated by Aoe2AIEditor: LibAoe2AISharp:Ver.0.0.0.1\r\n" +
                ";File: TestAIFile\r\n" +
                ";Author: author name\r\n" +
                ";Date: 2020/03/12 20:55:29\r\n" +
                ";===========================================================================...";

            // Act
            var testClass = new TestPerFile {
                Author = "author name",
                PathName = "c:\\dummyPath",
            };

            // Assert
            Assert.AreEqual(testClass.GetType().Name, testClass.FileName);
            Assert.AreNotEqual(expectedOutputScript, testClass.OutputScript);
        }
    }
}