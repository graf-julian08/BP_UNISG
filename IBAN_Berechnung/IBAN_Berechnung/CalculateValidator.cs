using System.Numerics;

namespace IBAN_Berechnung
{
    public class CalculateValidator
    {
        public bool ValidateIBAN(string iban)
        {
            string countryCode = null;

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