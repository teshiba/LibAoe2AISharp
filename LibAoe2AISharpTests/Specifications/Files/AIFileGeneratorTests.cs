using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class AIFileGeneratorTests
    {
        [TestMethod]
        public void OutputFilesTest()
        {
            // Arrange
            var perFileData = string.Empty;
            var aiFileData = string.Empty;

            var aiFile = new TestAIFileGenerator {
                PathName = Environment.CurrentDirectory + @"\",
            };

            // Act
            aiFile.OutputFiles();

            using(var reader = new StreamReader(aiFile.PathName
                                                + aiFile.FileName + ".per")) {
                perFileData = reader.ReadToEnd();
            }

            using(var reader = new StreamReader(aiFile.PathName
                                                + aiFile.FileName + ".ai")) {
                aiFileData = reader.ReadToEnd();
            }

            // Assert
            Assert.AreEqual(aiFile.FileName, "TestAIFileGenerator");
            Assert.AreEqual(aiFile.OutputScript, perFileData);
            Assert.AreEqual(string.Empty, aiFileData);
        }
    }
}