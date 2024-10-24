using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class InsertionSort
    {
        public static void InsertSort_Algo(int[] arr, int n)
        {
            for(int i=0; i<n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            Console.WriteLine("After Insertion sort: ");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
