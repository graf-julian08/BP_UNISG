using DateFormat;

namespace DateFormatTest
{
    [TestClass]
    public sealed class DateTest
    {
        [TestMethod]
        public void TestDateFormat_CH()
        {
            // Arrange
            int tag = 18;
            int month = 11;
            int year = 2008;
            string chooseFormat = "CH";
            string expectedResult = "18.11.2008";

            // Act
            string result = FormatDate.FormatDatum(tag, month, year, chooseFormat);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDateFormat_US()
        {
            // Arrange
            int tag = 18;
            int month = 11;
            int year = 2008;
            string chooseFormat = "US";
            string expectedResult = "11/18/2008";

            // Act
            string result = FormatDate.FormatDatum(tag, month, year, chooseFormat);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDateFormat_ISO()
        {
            // Arrange
            int tag = 18;
            int month = 11;
            int year = 2008;
            string chooseFormat = "ISO";
            string expectedResult = "2008-11-18";

            // Act
            string result = FormatDate.FormatDatum(tag, month, year, chooseFormat);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}