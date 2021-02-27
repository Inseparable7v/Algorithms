using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        public List<int> Sort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int median = unsorted.Count / 2;
            for (int i = 0; i < median; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = median; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }

        //Method takes two sorted "sublists" (left and right) 
        //of original list and merges them into a new colletion
        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>(); //The new collection

            while (left.Any() || right.Any())
            {
                if (left.Any() && right.Any())
                {
                    //Comparing the first element of each sublist 
                    //to see which is smaller
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Any())
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Any())
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
