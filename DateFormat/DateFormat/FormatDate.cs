namespace DateFormat
{
    public class FormatDate
    {
        public static string FormatDatum(int Tag, int Monat, int Jahr, string chooseFormat)
        {
            //Console.Write("Bitte Format angeben (CH, US oder ISO): ");
            //string chooseFormat = (Console.ReadLine()).ToUpper();

            switch (chooseFormat)
            {
                case "CH":
                    return $"{Tag:D2}.{Monat:D2}.{Jahr}";

                case "US":
                    return $"{Monat:D2}/{Tag:D2}/{Jahr}";

                case "ISO":
                    return $"{Jahr}-{Monat:D2}-{Tag:D2}";

                default:
                    return "Fehler beim Datum eingeben.";
            }
        }
    }
}