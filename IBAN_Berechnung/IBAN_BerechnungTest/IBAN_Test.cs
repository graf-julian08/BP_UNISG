using IBAN_Berechnung;

namespace IBAN_BerechnungTest
{
    [TestClass]
    public sealed class IBAN_Test
    {
        [TestMethod]
        public void TestIBANFormat1()
        {
            // Arrange
            string accountNumber = "70090100";
            string bankCode = "1234567890"; 
            string countryCode = "CH";
            string expectedResult = "CH79123456789070090100";

            // Act
            CalculateSum calc = new CalculateSum();
            string result = calc.IBANSum(accountNumber, bankCode, countryCode);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestIBANFormat2()
        {
            // Arrange
            string accountNumber = "98108225";
            string bankCode = "0987654321";
            string countryCode = "CH";
            string expectedResult = "CH95098765432198108225";

            // Act
            CalculateSum calc = new CalculateSum();
            string result = calc.IBANSum(accountNumber, bankCode, countryCode);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestIBANFormat3()
        {
            // Arrange
            string accountNumber = "81364286";
            string bankCode = "1029384756";
            string countryCode = "DE";
            string expectedResult = "DE50102938475681364286";

            // Act
            CalculateSum calc = new CalculateSum();
            string result = calc.IBANSum(accountNumber, bankCode, countryCode);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestIBANFormatWrong1()
        {
            // Arrange
            string accountNumber = "70090100";
            string bankCode = "1234567890";
            string countryCode = "CH";
            string expectedResult = "CH33333333333333333333";

            // Act
            CalculateSum calc = new CalculateSum();
            string result = calc.IBANSum(accountNumber, bankCode, countryCode);

            // Assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestIBANFormatWrong2()
        {
            // Arrange
            string accountNumber = "98108225";
            string bankCode = "0987654321";
            string countryCode = "CH";
            string expectedResult = "DE02981082250987654321";

            // Act
            CalculateSum calc = new CalculateSum();
            string result = calc.IBANSum(accountNumber, bankCode, countryCode);

            // Assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestIBANFormatWrong3()
        {
            // Arrange
            string accountNumber = "81364286";
            string bankCode = "1029384756";
            string countryCode = "DE";
            string expectedResult = "DE12345678901223344556";

            // Act
            CalculateSum calc = new CalculateSum();
            string result = calc.IBANSum(accountNumber, bankCode, countryCode);

            // Assert
            Assert.AreNotEqual(expectedResult, result);
        }
    }
}