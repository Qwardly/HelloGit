using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloGit
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var initialArray = new[] {1, 5, 3, 2, 5, 6};
            var sortedArray = new[] {1, 2, 3, 5, 5, 6};

            BubbleSort(initialArray);

            if (!initialArray.Intersect(sortedArray).Any()) throw new Exception("Sorting doesn't work!");
            Console.WriteLine("complete!");
        }

        private static void BubbleSort(IList<int> array)
        {
            for (int i = 0; i < array.Count; i++)
                for (int j = 0; j < array.Count - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
        }
    }
}