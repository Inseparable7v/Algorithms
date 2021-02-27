using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public Array Sort(int[] array)
        {
            var count = array.Length - 1;

            int temp, smallest;

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
                //5. Swap the found-smallest value with the current value
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }

            return array;
        }
    }
}
