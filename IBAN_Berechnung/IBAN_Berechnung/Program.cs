namespace IBAN_Berechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSum calcSum = new CalculateSum();
            string iban = calcSum.IBANSum("70090100", "1234567890", "CH");

            CalculateValidator valid = new CalculateValidator();
            valid.ValidateIBAN("7899879874");
        }
    }
}