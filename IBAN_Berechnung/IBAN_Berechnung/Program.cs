namespace IBAN_Berechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSum calcSum = new CalculateSum();
            calcSum.IBANSum("70090100", "1234567890", "CH");
        }
    }
}