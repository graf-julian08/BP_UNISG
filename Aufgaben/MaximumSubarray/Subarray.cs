namespace MaximumSubarray
{
    public class Subarray
    {
        public (int maxSum, int maxSumStartPos, int maxSumEndPos) FindMaxSubarray(List<int> numberList)
        {
            int maxSum = numberList[0];
            int currentSum = numberList[0];
            int maxSumStartPos = 0;
            int newStartPos = 0;
            int maxSumEndPos = 0;

            for (int currentPos = 1; currentPos < numberList.Count; currentPos++)
            {
                if (currentSum + numberList[currentPos] < numberList[currentPos])
                {
                    currentSum = numberList[currentPos];
                    newStartPos = currentPos;
                }
                else
                {
                    currentSum += numberList[currentPos];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumStartPos = newStartPos;
                    maxSumEndPos = currentPos;
                }
            }

            Console.WriteLine($"\nDie grösste Summe ist {maxSum}, von {maxSumStartPos} bis {maxSumEndPos}.");
            return (maxSum, maxSumStartPos, maxSumEndPos);
        }
    }
}