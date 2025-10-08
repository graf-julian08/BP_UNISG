using IBAN_Berechnung;

namespace IBAN_BerechnungTest
{
    [TestClass]
    public sealed class Validator_Test
    {
        [TestMethod]
        public void TestValidator_attrue()
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
        public void TestValidator_defalse()
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
        public void TestValidator_attrue2()
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
        public void TestValidatorWrong_frtrue()
        {
            // Arrange
            string iban = "FR1420041010050500013M02606";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong_chtrue()
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
        public void TestValidatorWrong_chfalse()
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

        [TestMethod]
        public void TestValidatorWrong_null()
        {
            // Arrange
            string iban = null;
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong_empty()
        {
            // Arrange
            string iban = "";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong_space()
        {
            // Arrange
            string iban = "   ";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong_a()
        {
            // Arrange
            string iban = "A";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong_as()
        {
            // Arrange
            string iban = "AS";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong_asw()
        {
            // Arrange
            string iban = "ASW";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong_as12()
        {
            // Arrange
            string iban = "AS12";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong_sskk()
        {
            // Arrange
            string iban = "SSKK?";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestValidatorWrong_7899879874()
        {
            // Arrange
            string iban = "7899879874";
            bool expectedResult = true;

            // Act
            CalculateValidator calc = new CalculateValidator();
            bool testResult = calc.ValidateIBAN(iban);

            // Assert
            Assert.AreNotEqual(expectedResult, testResult);
        }
    }
}