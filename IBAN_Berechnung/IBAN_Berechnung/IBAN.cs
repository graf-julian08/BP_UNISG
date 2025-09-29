namespace IBAN_Berechnung
{
    public class IBAN
    {
        public string AccountNumber { get; private set; }
        public string BankCode { get; private set; }
        public string CountryCode { get; private set; }

        public IBAN(string accountNumber, string bankCode, string countryCode)
        {
            AccountNumber = accountNumber;
            BankCode = bankCode;
            CountryCode = countryCode;
        }
    }
}