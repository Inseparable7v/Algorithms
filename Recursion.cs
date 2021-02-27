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

    }

}
