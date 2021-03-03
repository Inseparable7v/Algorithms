using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public InsertionSort()
        {

        }

        public int[] Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }

            return array;
        }

        private void Swap(int[] array, in int first, int second)
        {
            var temp = array[first];
            array[second] = array[first];
            array[first] = temp;
        }
    }
}
