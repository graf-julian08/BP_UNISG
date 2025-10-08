namespace MaximumSubarray
{
    public class Subarray
    {
        public (int maxSum, int maxSumStartPosition, int maxSumEndPosition) FindMaxSubarray(List<int> numberList)
        {
            int maxSum = numberList[0];
            int maxSumStartPosition = 0;
            int maxSumEndPosition = 0;

            for (int startPosition = 0; startPosition < numberList.Count; startPosition++)
            {
                int sum = 0;
                for (int endPosition = startPosition; endPosition < numberList.Count; endPosition++)
                {

                    sum += numberList[endPosition];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxSumStartPosition = startPosition;
                        maxSumEndPosition = endPosition;
                    }
                }
            }

            Console.WriteLine($"\nDie grösste Summe ist {maxSum}, von {maxSumStartPosition} bis {maxSumEndPosition}.");
            return (maxSum, maxSumStartPosition, maxSumEndPosition);
        }
    }
}