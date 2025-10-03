using System.Numerics;

namespace IBAN_Berechnung
{
    public class CalculateValidator
    {
        public bool ValidateIBAN(string iban)
        {
            string countryCode = null;

            if (string.IsNullOrEmpty(iban) || iban.Length < 3)
                return false;

             if (!char.IsLetter(iban[0]) || !char.IsLetter(iban[1]))
                return false;

            for (int i = 2; i < iban.Length; i++)
            {
                if (!char.IsDigit(iban[i]))
                {
                    return false;
                }
            }

            int firstNumber = int.Parse(iban[2].ToString());
            int secondNumber = int.Parse(iban[3].ToString());


            CountryCode cc = new CountryCode();
            string transformedLetters = cc.TransformLetter(iban, countryCode);


            string subresult = ($"{iban}{transformedLetters}{firstNumber}{secondNumber}").Substring(4);

            //Console.WriteLine(subresult);

            int checkOne = (int)(BigInteger.Parse(subresult) % 97);

            //Console.WriteLine(checkOne);

            if (checkOne == 1)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }
    }
}