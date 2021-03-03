using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        /// <summary>
        /// Memory: 1
        /// Complexity: O(n2)
        /// Stable: No
        /// </summary>
        private int temp, smallest;
        public int[] Sort(int[] array)
        {
            var count = array.Length - 1;
            //The algorithm builds the sorted list from the left.
            //1. For each item in the array...
            for (int i = 0; i < count - 1; i++)
            {
                //2. ...assume the first item is the smallest value
                smallest = i;
                //3. Cycle through the rest of the array
                for (int j = i + 1; j < count; j++)
                {
                    //4. If any of the remaining values are smaller, 
                    //   find the smallest of these
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                Swap(array, i);
            }

            return array;
        }

        //5. Swap the found-smallest value with the current value
        public void Swap(int[] array,int index)
        {
            temp = array[smallest];
            array[smallest] = array[index];
            array[index] = temp;
        }
    }
}
