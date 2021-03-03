using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        public BubbleSort()
        {
            
        }
        /// <summary>
        /// Memory 1
        /// Complexity O(n2)
        /// Stable: YES
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //For loop starts from 1 because we need to take the right element(i + 1) 
                for (int j = 1; j < array.Length - 1; j++)
                {
                    //Check if previous element is bigger then current element and if so,Swap positions of the elements
                    if (array[j - 1] > array[j])
                    {
                        Swap(array, j - 1, j);
                    }
                }
            }

            return array;
        }

        private void Swap(int[] array, int first, int second)
        {
            var temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
