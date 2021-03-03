using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class QuickSort
    {
        //O(nlogn) 
        public int[] Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(array, start, end);
                Sort(array, start, pivot - 1);
                Sort(array, pivot + 1, end);
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
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, end);
            return i + 1;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
