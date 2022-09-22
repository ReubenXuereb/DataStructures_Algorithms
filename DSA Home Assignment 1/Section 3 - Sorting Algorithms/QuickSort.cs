using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_3___Sorting_Algorithms
{
    class QuickSort
    {
        /// <summary>
        /// Sorts the Sequence of Numbers using the Quick Sort Algorithm
        /// </summary>
        /// <param name="unsortedSequence">array of unsorted numbers</param>
        /// <returns>array of sorted numbers</returns>
        public static void Sort(int[] arr, int left, int right)
        {
            int x = left;
            int y = right;

            var pivot = arr[(left + right) / 2];

            while (x <= y)
            {
                while (arr[x] < pivot)
                {
                    x++;
                }

                while (arr[y] > pivot)
                {
                    y--;
                }

                if (x <= y)
                {
                    var tmp = arr[x];
                    arr[x] = arr[y];
                    arr[y] = tmp;

                    x++;
                    y--;
                }
            }

            if (left < y)
            {
                Sort(arr, left, y);
            }

            if (x < right)
            {
                Sort(arr, x, right);
            }
        }

        internal int[] Sort(int[] unsortedArray)
        {
            Sort(unsortedArray,0, unsortedArray.Length - 1);
            return unsortedArray;
        }
    }
}
        
      





  

