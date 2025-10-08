using System.Numerics;

namespace IBAN_Berechnung
{
    public class CalculateSum
    {
        public string IBANSum(string accountNumber, string bankCode, string countryCode)
        {

            if (string.IsNullOrEmpty(accountNumber) || accountNumber.Length < 3 || !accountNumber.All(char.IsDigit))
            {
                return "Ungültige Kontonummer";
            }

            if (string.IsNullOrEmpty(bankCode) || bankCode.Length < 5 || !bankCode.All(char.IsDigit))
            {
                return "Ungültige Bankleitzahl";
            }

            if (string.IsNullOrEmpty(countryCode) || !countryCode.All(char.IsLetter) || countryCode.Length != 2) {
                return "Ungültige Ländervorwahl";
            }

            string iban = null;
            string bban = ($"{bankCode}{accountNumber}");


            CountryCode cc = new CountryCode();
            string transformedLetters = cc.TransformLetter(iban, countryCode);


            string subresult = ($"{bban}{transformedLetters}00");

            BigInteger ibanNumber = BigInteger.Parse(subresult);

            int remainder = (int)(ibanNumber % 97);

            int remainder98 = 98 - remainder;

            iban = ($"{countryCode}{remainder98:D2}{bban}");

            return iban;
        }
    }
}