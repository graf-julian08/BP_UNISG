namespace DictionaryZuIndex
{
    public class TransformDict
    {
        public Dictionary<string, List<string>> CreateIndex(Dictionary<string, List<string>> startDict)
        {
            Dictionary<string, List<string>> invertedDict = new Dictionary<string, List<string>>();

            foreach (var element in startDict)
            {
                //Console.WriteLine($"{element.Key}: {string.Join(", ", element.Value)}");

                foreach (string value in element.Value)
                {
                    invertedDict[value].Add(element.Key);
                }

            }

            return invertedDict;
        }
    }
}