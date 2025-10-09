using System.Diagnostics;

namespace MaximumSubarray
{
    internal class Program
    {
        static void Main()
        {
            Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();

            int listLength = 100000000;

            GenerateList generator = new GenerateList();
            generator.GenerateRandomList(listLength);

            string listPath = "numbers.txt";
            List<int> numberList = new List<int>();

            foreach (var line in File.ReadLines(listPath))
            {
                foreach (var numStr in line.Split(','))
                {
                    if (int.TryParse(numStr, out int num))
                        numberList.Add(num);
                }
            }

            Subarray subarray = new Subarray();
            subarray.FindMaxSubarray(numberList);

            stopwatch.Stop();
            Console.WriteLine($"\nLaufzeit: {stopwatch.Elapsed}");
        }
    }
}