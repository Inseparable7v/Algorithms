using System;
using System.Linq;
using SortingAlgorithms;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            var recursion = new Recursion();

            recursion.Gen01(array, 0);
            QuickSortDemo();

        }

        public static void QuickSortDemo()
        {
            var array = new int[6] { 6, 11, 2, 3, 7, 10 };

            var arrayLength = array.Length - 1;

            var quickSort = new QuickSort();

            var sortedArray = quickSort.QuickSortAlgorithm(array, 0, arrayLength);

            foreach (var num in sortedArray)
            {
                Console.Write(num + ", ");
            }
        }
    }
}
