using System.Diagnostics;

namespace MaximumSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            GenerateList generator = new GenerateList();
            generator.GenerateRandomList();

            string path = System.IO.Path.GetFullPath("numbers.txt");
            string fileContent = System.IO.File.ReadAllText(path);

            StartArray array = new StartArray();
            List<int> numberList = array.CreateArray(fileContent);

            Subarray subarray = new Subarray();
            subarray.FindMaxSubarray(numberList);

            stopwatch.Stop();
            Console.WriteLine($"\nLaufzeit: {stopwatch.Elapsed}");
        }
    }
}