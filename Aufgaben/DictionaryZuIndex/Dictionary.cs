namespace DictionaryZuIndex
{
    public class Dictionary
    {
        public Dictionary<string, List<string>> CreateDictionary()
        {
            Dictionary<string, List<string>> startDict = new Dictionary<string, List<string>>();

            startDict["Blume"] = new List<string> { "Blatt", "Stiel", "Blüte", "Grün" };
            startDict["Baum"] = new List<string> { "Stamm", "Ast", "Blüte", "Grün", "Blatt" };
            startDict["Pilz"] = new List<string> { "Hut", "Farbe", "Stiel" };

            return startDict;
        }
    }
}