using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal static class Test
    {
        public static void TestSortRandomArray()
        {
            int[] input = { 14, 4, 0, 11, 18, 17, 12, 5, 19, 18 };
            int[] expectedOutput = { 0, 4, 5, 11, 12, 14, 17, 18, 18, 19 };

            TestSort(input, expectedOutput);
        }

        public static void TestAlreadySortedArray()
        {
            int[] input = { 0, 4, 5, 11, 12, 14, 17, 18, 18, 19 };
            int[] expectedOutput = { 0, 4, 5, 11, 12, 14, 17, 18, 18, 19 };

            TestSort(input, expectedOutput);
        }

        public static void TestInverseSortedArray()
        {
            int[] input = { 19, 18, 18, 17, 14, 12, 11, 5, 4, 0 };
            int[] expectedOutput = { 0, 4, 5, 11, 12, 14, 17, 18, 18, 19 };

            TestSort(input, expectedOutput);
        }

        public static void TestSortEmptyArray()
        {
            int[] input = { };
            int[] expectedOutput = { };

            TestSort(input, expectedOutput);
        }

        private static void TestSort(int[] input, int[] expectedOutput)
        {
            Console.WriteLine("Input");
            DisplayArray(input);

            Console.WriteLine("Expected Result");
            DisplayArray(expectedOutput);

            // Does the sorting
            Program.Sort(input);

            // Post: input should now be sorted

            bool pass = CheckArraysEqual(input, expectedOutput);

            // Display the result
            Console.WriteLine("Actual Result");
            DisplayArray(input);

            // Say PASS or FAIL
            Console.WriteLine(pass ? "PASSED" : "FAILED");
            Console.WriteLine();
        }

        private static void DisplayArray(int[] array)
        {
            Console.Write("[");
            foreach (int element in array)
            {
                Console.Write("{0}, ", element);
            }
            Console.WriteLine("]");
        }

        // Return true, if array and other have the same elements
        private static bool CheckArraysEqual(int[] array, int[] other)
        {
            // Arrays of different lengths are definitely different
            if (array.Length != other.Length) return false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != other[i]) return false;
            }
            return true;
        }
    }
}
