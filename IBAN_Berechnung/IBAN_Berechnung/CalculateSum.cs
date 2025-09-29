using System.Numerics;

namespace IBAN_Berechnung
{
    public class CalculateSum
    {
        public string IBANSum(string accountNumber, string bankCode, string countryCode)
        {
            string BBAN = accountNumber + bankCode;

            char firstChar = countryCode[0];
            char secondChar = countryCode[1];

            string firstLetter = "";
            string secondLetter = "";

            switch (firstChar)
            {
                case 'A': 
                    firstLetter = "10"; 
                    break;

                case 'B': 
                    firstLetter = "11"; 
                    break;

                case 'C': 
                    firstLetter = "12"; 
                    break;

                case 'D': 
                    firstLetter = "13"; 
                    break;

                case 'E':
                    firstLetter = "14";
                    break;

                case 'F':
                    firstLetter = "15";
                    break;

                case 'G':
                    firstLetter = "16";
                    break;

                case 'H':
                    firstLetter = "17";
                    break;

                case 'I':
                    firstLetter = "18";
                    break;

                case 'J':
                    firstLetter = "19";
                    break;

                case 'K':
                    firstLetter = "20";
                    break;

                case 'L':
                    firstLetter = "21";
                    break;

                case 'M':
                    firstLetter = "22";
                    break;

                case 'N':
                    firstLetter = "23";
                    break;

                case 'O':
                    firstLetter = "24";
                    break;

                case 'P':
                    firstLetter = "25";
                    break;

                case 'Q':
                    firstLetter = "26";
                    break;

                case 'R':
                    firstLetter = "27";
                    break;

                case 'S':
                    firstLetter = "28";
                    break;

                case 'T':
                    firstLetter = "29";
                    break;

                case 'U':
                    firstLetter = "30";
                    break;

                case 'V':
                    firstLetter = "31";
                    break;

                case 'W':
                    firstLetter = "32";
                    break;

                case 'X':
                    firstLetter = "33";
                    break;

                case 'Y':
                    firstLetter = "34";
                    break;

                case 'Z':
                    firstLetter = "35";
                    break;
            }

            switch (secondChar)
            {
                case 'A':
                    secondLetter = "10";
                    break;

                case 'B':
                    secondLetter = "11";
                    break;

                case 'C':
                    secondLetter = "12";
                    break;

                case 'D':
                    secondLetter = "13";
                    break;

                case 'E':
                    secondLetter = "14";
                    break;

                case 'F':
                    secondLetter = "15";
                    break;

                case 'G':
                    secondLetter = "16";
                    break;

                case 'H':
                    secondLetter = "17";
                    break;

                case 'I':
                    secondLetter = "18";
                    break;

                case 'J':
                    secondLetter = "19";
                    break;

                case 'K':
                    secondLetter = "20";
                    break;

                case 'L':
                    secondLetter = "21";
                    break;

                case 'M':
                    secondLetter = "22";
                    break;

                case 'N':
                    secondLetter = "23";
                    break;

                case 'O':
                    secondLetter = "24";
                    break;

                case 'P':
                    secondLetter = "25";
                    break;

                case 'Q':
                    secondLetter = "26";
                    break;

                case 'R':
                    secondLetter = "27";
                    break;

                case 'S':
                    secondLetter = "28";
                    break;

                case 'T':
                    secondLetter = "29";
                    break;

                case 'U':
                    secondLetter = "30";
                    break;

                case 'V':
                    secondLetter = "31";
                    break;

                case 'W':
                    secondLetter = "32";
                    break;

                case 'X':
                    secondLetter = "33";
                    break;

                case 'Y':
                    secondLetter = "34";
                    break;

                case 'Z':
                    secondLetter = "35";
                    break;
            }

            string Subresult = BBAN + firstLetter + secondLetter + "00";

            BigInteger resultMod = BigInteger.Parse(Subresult) % 97;
            //Console.WriteLine(resultMod);

            string resultMod98 = (98 - (int)resultMod).ToString("D2");

            string result = ($"{countryCode}{resultMod98}{BBAN}");

            //Console.WriteLine(result);

            return result;
        }
    }
}