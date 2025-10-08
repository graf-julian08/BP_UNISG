namespace MaximumSubarray
{
    public class StartArray
    {
        public List<int> CreateArray(string printedNumberList)
        {
            Console.WriteLine(printedNumberList);
            List<int> numberList = printedNumberList.Split(',').Select(Int32.Parse).ToList();

            return numberList;
        }
    }
}