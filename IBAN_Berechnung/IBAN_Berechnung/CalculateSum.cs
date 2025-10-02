using System;
using System.Numerics;

namespace IBAN_Berechnung
{
    public class CalculateSum
    {
        public string IBANSum(string accountNumber, string bankCode, string countryCode)
        {
            string iban = null;
            string BBAN = ($"{bankCode}{accountNumber}");


            CountryCode cc = new CountryCode();
            string transformedLetters = cc.TransformLetter(iban, countryCode);


            string subresult = ($"{BBAN}{transformedLetters}00");

            BigInteger ibanNumber = BigInteger.Parse(subresult);

            int remainder = (int)(ibanNumber % 97);

            int remainder98 = 98 - remainder;

            iban = ($"{countryCode}{remainder98:D2}{BBAN}");

            //Console.WriteLine(iban);
            return iban;
        }
    }
}
