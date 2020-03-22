using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Script;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class ScriptTests
    {
        [TestMethod]
        public void ConvertTest()
        {
            // Arrange
            var targetString = "test_script_name";
            var expectedString = "test-script-name";

            // Act
            var convertedStringValid = Convert(targetString);
            var convertedStringInvalid = Convert(null);

            // Assert
            Assert.AreEqual(expectedString, convertedStringValid);
            Assert.AreEqual(null, convertedStringInvalid);
        }

        [TestMethod]
        public void FormatTest()
        {
            // Arrange
            var name = "testName";
            var comment = "testComment";
            string[] paramString = {
                "testParam0",
                "testParam1",
                "testParam2",
            };
            string[] paramNullString = {
                "testParam0",
                null,
                "testParam2",
            };

            var expectedString1 = "(testName testParam0 testParam1 testParam2) ;testComment";
            var expectedString2 = "(testName testParam0 testParam1 testParam2) ;testComment";
            var expectedString3 = "(testName) ;testComment";
            var expectedString4 = "(testName testParam0 testParam2) ;testComment";

            // Act
            var formattedString1 = Format(
                                                 name,
                                                 comment,
                                                 paramString[0],
                                                 paramString[1],
                                                 paramString[2]);
            var formattedString2 = Format(name, comment, paramString);
            var formattedString3 = Format(name, comment, null);
            var formattedString4 = Format(name, comment, paramNullString);

            // Assert
            Assert.AreEqual(expectedString1, formattedString1);
            Assert.AreEqual(expectedString2, formattedString2);
            Assert.AreEqual(expectedString3, formattedString3);
            Assert.AreEqual(expectedString4, formattedString4);
        }

        [TestMethod]
        public void TabTest()
        {
            // Arrange
            string[] expectedString = {
                string.Empty,
                "    ",
                "        ",
                "            ",
            };

            // Act
            string[] convertedString = {
                Tab(0),
                Tab(1),
                Tab(2),
                Tab(3),
            };

            // Assert
            for (int i = 0; i < expectedString.Length; i++) {
                Assert.AreEqual(expectedString[i], convertedString[i]);
            }
        }
    }
}