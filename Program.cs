using System;
using System.Linq;
using SortingAlgorithms;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 232, 3, 564, 5, 64, 11002 };

            var bubbleSort = new BubbleSort();
            var insertionSort = new InsertionSort();
            var quickSort = new QuickSort();
            var mergeSort = new MergeSort();
            var selectionSort = new SelectionSort();

            Console.Write("InsertionSort: ");
            Console.WriteLine(string.Join(", ", insertionSort.Sort(array)));
            Console.WriteLine();
            Console.Write("SelectionSort: ");
            Console.WriteLine(string.Join(", ", selectionSort.Sort(array)));
            Console.WriteLine();
            Console.Write("BubbleSort: ");
            Console.WriteLine(string.Join(", ", bubbleSort.Sort(array)));
            Console.WriteLine();
            Console.Write("QuickSort: ");
            Console.WriteLine(string.Join(", ", quickSort.Sort(array, 0, array.Length - 1)));
            Console.WriteLine();
            Console.Write("MergeSort: ");
            Console.WriteLine(string.Join(", ", mergeSort.Sort(array.ToList())));
        }
    }
}
