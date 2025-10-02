using IBAN_Berechnung;

namespace IBAN_BerechnungTest
{
    [TestClass]
    public sealed class Validator_Test
    {
        [TestMethod]
        public void TestValidator1()
        {
            // Arrange
            string iban = "AT411100000237571500";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidator2()
        {
            // Arrange
            string iban = "DE911000000001234567890";
            bool expectedResult = false;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidator3()
        {
            // Arrange
            string iban = "AT411100000237571501";
            bool expectedResult = false;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong1()
        {
            // Arrange
            string iban = "AT41110000023433345715";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong2()
        {
            // Arrange
            string iban = "CH711000001234567890";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong3()
        {
            // Arrange
            string iban = "CH2660031709406451876";
            bool expectedResult = false;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }
    }
}
