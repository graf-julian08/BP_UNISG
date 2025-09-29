namespace DateFormat
{
    public class Date
    {
        public int Tag { get; private set; }
        public int Monat { get; private set;  }
        public int Jahr { get; private set; }

        public Date(int tag, int monat, int jahr)
        {
            Tag = tag;
            Monat = monat; 
            Jahr = jahr;
        }
    }
}