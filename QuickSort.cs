using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class QuickSort
    {
        //O(nlogn) 
        public Array QuickSortAlgorithm(int[] array, int init, int end)
        {
            if (init < end)
            {
                int pivot = Partition(array, init, end);
                QuickSortAlgorithm(array, init, pivot - 1);
                QuickSortAlgorithm(array, pivot + 1, end);
            }
            return array;
        }

        //O(n)
        private int Partition(int[] array, int init, int end)
        {
            int last = array[end];
            int i = init - 1;
            for (int j = init; j < end; j++)
            {
                if (array[j] <= last)
                {
                    i++;
                    Exchange(array, i, j);
                }
            }
            Exchange(array, i + 1, end);
            return i + 1;
        }

        private void Exchange(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
