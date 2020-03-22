using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class PerFileGeneratorTests
    {
        [TestMethod]
        public void OutputFileTest()
        {
            // Arrange
            var readScript = string.Empty;

            var perFile = new TestPerFileGenerator {
                PathName = Environment.CurrentDirectory + @"\",
            };

            // Act
            perFile.OutputFile();

            using(var reader = new StreamReader(perFile.PathName
                                                + perFile.FileName + ".per")) {
                readScript = reader.ReadToEnd();
            }

            // Assert
            Assert.AreEqual(perFile.OutputScript, readScript);
        }
    }
}