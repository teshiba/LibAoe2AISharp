using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class AIFileTests
    {
        [TestMethod]
        public void AIFileTest()
        {
            // Arrange
            var expectedPathName = ".\\";
            var expectedAuthorName = "author name";
            var perfile1 = new TestPerFile();
            var perfile2 = new TestPerFile {
                Author = "file2 author",
            };

            // Act
            var testClass = new TestAIFile(expectedPathName, expectedAuthorName, perfile1, perfile2);

            // Assert
            Assert.AreEqual(perfile1, testClass.RelatedFiles[0]);
            Assert.AreEqual(perfile2, testClass.RelatedFiles[1]);
        }

        [TestMethod]
        public void OutputFilesTest()
        {
            // Arrange
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            typeof(GoalId).GetField("count", flag).SetValue(null, 0);
            typeof(GoalValue).GetField("count", flag).SetValue(null, 0);

            var expectedPathName = ".\\";
            var expectedAuthorName = "author name";
            var perFileData = string.Empty;
            var aiFileData = string.Empty;
            var perfile1 = new TestPerFile();
            var perfile2 = new TestPerFile {
                Author = "file2 author",
            };

            var expectedfullPathName = expectedPathName + "TestAIFile.ai";
            File.Delete(expectedfullPathName);

            // Act
            var testClass = new TestAIFile(expectedPathName, expectedAuthorName, perfile1, perfile2);
            testClass.OutputFiles();

            using (var reader = new StreamReader(testClass.PathName
                                    + testClass.FileName + ".per")) {
                perFileData = reader.ReadToEnd();
            }

            using (var reader = new StreamReader(testClass.PathName
                                                + testClass.FileName + ".ai")) {
                aiFileData = reader.ReadToEnd();
            }

            // Assert
            Assert.AreEqual(testClass.OutputScript, perFileData);
            Assert.AreEqual(string.Empty, aiFileData);
        }

        [TestMethod]
        public void GetCommandGroupsTest()
        {
        }

        [TestMethod]
        public void GetLoadCommandTest()
        {
        }

        [TestMethod]
        public void GetUserDefconstTest()
        {
        }
    }
}