namespace DictionaryZuIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dict = new Dictionary();
            Dictionary<string, List<string>> startDict = dict.CreateDictionary();

            TransformDict transformDict = new TransformDict();
            transformDict.CreateIndex(startDict);
        }
    }
}