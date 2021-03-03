using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Recursion
    {
        public Recursion()
        {
        }

        public int Sum(int[] array, int index)
        {
            if (index >= array.Length - 1)
            {
                return array[index];
            }

            return array[index] + Sum(array, index + 1);
        }

        public void Gen01(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                Gen01(vector, index + 1);
            }
        }

        public void NestedLoopsWithRecursion(int[] arr, int index, int start)
        {
            if (start == arr.Length)
            {
                Console.WriteLine(string.Join("", arr));
                return;
            }

            for (int i = 1; i <= index; i++)
            {
                arr[start] = i;
                NestedLoopsWithRecursion(arr, index, start + 1);
            }
        }

        private static void CombinationsWithoutRep(int[] slots, int[] array, int index, int start)
        {
            if (index >= slots.Length)
            {
                Console.WriteLine(string.Join(" ", slots));
                return;
            }

            for (int i = start; i < array.Length; i++)
            {
                slots[index] = array[i];
                CombinationsWithoutRep(slots, array, index + 1, i + 1);
            }
        }

        public void CharPyramid(int n)
        {
            if (n <= 0)
            {
                return;
            }
            Console.WriteLine(new string('*', n));

            CharPyramid(n - 1);

            Console.WriteLine(new string('#', n));
        }

        public int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
        private static void ReverseArray(int[] array, int start, int end)
        {
            if (start >= end)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            var temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            ReverseArray(array, start + 1, end - 1);
        }
    }
}
