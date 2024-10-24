namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 1, 2, 4 };
            int n = arr.Length;
            BubbleSort.BubbleSort_Algo(arr,n);
            Console.WriteLine();
            SelectionSort.SelectionSort_Algo(arr, n);
            Console.WriteLine();
            InsertionSort.InsertSort_Algo(arr, n);
            Console.WriteLine();
            QuickSort.QuickSort_Algo(arr, 0, n-1);
            QuickSort.Print(arr);
        }
    }
}
