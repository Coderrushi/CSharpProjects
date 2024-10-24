using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class QuickSort
    {
        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;
            for(int j = start; j <= end-1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, end);
            return i + 1;
        }
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public static void QuickSort_Algo(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pi = Partition(arr, start, end);
                QuickSort_Algo(arr, start, pi - 1);
                QuickSort_Algo(arr, pi + 1, end);
            }
        }
        public static void Print(int[] arr)
        {
            Console.WriteLine("After Quick sort: ");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
