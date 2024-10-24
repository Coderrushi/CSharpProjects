using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class SelectionSort
    {
        public static void SelectionSort_Algo(int[] arr, int n)
        {
            for(int i=0; i<n-1; i++)
            {
                int mid_ind = i;
                for(int j=i+1; j<n; j++)
                {
                    if (arr[j] < arr[mid_ind])
                    {
                        mid_ind = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[mid_ind];
                arr[mid_ind] = temp;
            }
            Console.WriteLine("After Selection sort: ");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
