namespace DictionaryZuIndex
{
    public class TransformDict
    {
        public Dictionary<string, List<string>> CreateIndex(Dictionary<string, List<string>> startDict)
        {
            Dictionary<string, List<string>> invertedDict = new Dictionary<string, List<string>>();

            Console.WriteLine("Start Liste:\n");

            foreach (var element in startDict)
            {
                Console.WriteLine($"{element.Key}: {string.Join(", ", element.Value)}");

                foreach (string value in element.Value)
                {
                    //if (invertedDict.ContainsKey(element.Value) { 
                    if (invertedDict.ContainsKey(value))
                    {
                        //Console.WriteLine("Element schon in invertedDict");
                        invertedDict[value].Add(element.Key);
                    }
                    else
                    {
                        //invertedDict.Add(value, element.Key);
                        invertedDict.Add(value, new List<string> {element.Key});
                    }
                }
            }

            Console.WriteLine("\n\nNeue Liste:\n");

            foreach (var element in invertedDict)
            {
                Console.WriteLine($"{element.Key}: {string.Join(", ", element.Value)}");
            }

            return invertedDict;
        }
    }
}