using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public class InsertionSort : ISortable
    {
        public InsertionSort()
        {

        }

        public List<int> Sort(int[] array)
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

            return array.ToList();
        }

        private void Swap(int[] array, in int first, int second)
        {
            var temp = array[first];
            array[second] = array[first];
            array[first] = temp;
        }
    }
}
