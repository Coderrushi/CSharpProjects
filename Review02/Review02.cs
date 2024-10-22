using System.Globalization;

namespace Review02
{
    internal class Program
    {
        static int FindMaxEle(int[] arr)
        {
            int maxSum = arr[0], currSum = arr[0];
            int start = 0;
            int end = 0;
            int tempStart = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > currSum + arr[i])
                {
                    currSum = arr[i];
                    tempStart = i;
                }
                else
                {
                    currSum += arr[i];
                }
                if(currSum > maxSum)
                {
                    maxSum = currSum;
                    start = tempStart;
                    end = i;
                }
            }
            return maxSum;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 3, 4, 2};
            InsertionSort.Insertionsort(arr);
            //int maxSum = FindMaxEle(arr);
            //Console.WriteLine($"Maximum sum is: {maxSum}");
            
        }
    }
}
