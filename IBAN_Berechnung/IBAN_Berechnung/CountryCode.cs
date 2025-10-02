using System.Runtime.ExceptionServices;

namespace IBAN_Berechnung
{
    public class CountryCode
    {
        public string TransformLetter(string iban, string countryCode)
        {

            char[] countryLetters = new char[2];


            if (iban != null)
            {
                countryLetters[0] = iban[0];
                countryLetters[1] = iban[1];
            }
            else
            {
                countryLetters[0] = countryCode[0];
                countryLetters[1] = countryCode[1];
            }


            string[] countryNumbers = new string[2];

            int i = 0;

            foreach (char letter in countryLetters)
            {
                switch (letter)
                {
                    case 'A':
                        countryNumbers[i] = "10";
                        break;

                    case 'B':
                        countryNumbers[i] = "11";
                        break;

                    case 'C':
                        countryNumbers[i] = "12";
                        break;

                    case 'D':
                        countryNumbers[i] = "13";
                        break;

                    case 'E':
                        countryNumbers[i] = "14";
                        break;

                    case 'F':
                        countryNumbers[i] = "15";
                        break;

                    case 'G':
                        countryNumbers[i] = "16";
                        break;

                    case 'H':
                        countryNumbers[i] = "17";
                        break;

                    case 'I':
                        countryNumbers[i] = "18";
                        break;

                    case 'J':
                        countryNumbers[i] = "19";
                        break;

                    case 'K':
                        countryNumbers[i] = "20";
                        break;

                    case 'L':
                        countryNumbers[i] = "21";
                        break;

                    case 'M':
                        countryNumbers[i] = "22";
                        break;

                    case 'N':
                        countryNumbers[i] = "23";
                        break;

                    case 'O':
                        countryNumbers[i] = "24";
                        break;

                    case 'P':
                        countryNumbers[i] = "25";
                        break;

                    case 'Q':
                        countryNumbers[i] = "26";
                        break;

                    case 'R':
                        countryNumbers[i] = "27";
                        break;

                    case 'S':
                        countryNumbers[i] = "28";
                        break;

                    case 'T':
                        countryNumbers[i] = "29";
                        break;

                    case 'U':
                        countryNumbers[i] = "30";
                        break;

                    case 'V':
                        countryNumbers[i] = "31";
                        break;

                    case 'W':
                        countryNumbers[i] = "32";
                        break;

                    case 'X':
                        countryNumbers[i] = "33";
                        break;

                    case 'Y':
                        countryNumbers[i] = "34";
                        break;

                    case 'Z':
                        countryNumbers[i] = "35";
                        break;
                }
                i++;
            }

            string transformedLetters = string.Join("", countryNumbers);

            //Console.WriteLine(transformedLetters);

            return transformedLetters;
        }
    }
}
