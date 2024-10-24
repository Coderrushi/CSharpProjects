using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class BubbleSort
    {
        public static void BubbleSort_Algo(int[] arr, int n)
        {
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After Bubble sort: ");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
