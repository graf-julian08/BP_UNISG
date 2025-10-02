namespace IBAN_Berechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSum calcSum = new CalculateSum();
            string iban = calcSum.IBANSum("30120400", "152288", "DE");

            CalculateValidator valid = new CalculateValidator();
            valid.ValidateIBAN(iban);
        }
    }
}