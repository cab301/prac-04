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
            // Pre condition: Random array
            int[] array = { 1, 6, 3, 2, 5, 8, 7, 4, 9, 0 };
            int[] expectedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PerformTest(array, expectedArray);
        }

        public static void TestSortRandomArrayRepeated()
        {
            int[] array = { 6, 4, 5, 3, 4, 1, 2, 7, 3, 2 };
            int[] expectedArray = { 1, 2, 2, 3, 3, 4, 4, 5, 6, 7 };
            PerformTest(array, expectedArray);

        }

        public static void TestSortAlreadySortedArray()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expectedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PerformTest(array, expectedArray);

        }

        public static void TestSortInvertedArray()
        {
            int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] expectedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PerformTest(array, expectedArray);

        }

        public static void TestSortEmptyArray()
        {
            int[] array = { };
            int[] expectedArray = { };
            PerformTest(array, expectedArray);

        }

        public static void PerformTest(int[] input, int[] expected)
        {
            // Display the input and expected output
            Console.WriteLine("The input array is:");
            DisplayArray(input);
            Console.WriteLine("The expected array is:");
            DisplayArray(expected);
            // Call the sort method
            Program.InsertionSort(input);
            // Check the result
            bool pass = CheckArrayEqual(input, expected);
            // Display result
            Console.WriteLine(pass ? "PASS" : "FAIL");
            Console.WriteLine("End test");
        }

        public static void DisplayArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write("{0}, ", number);
            }
            Console.WriteLine();
        }

        // Check if array has the same elements as the other array
        public static bool CheckArrayEqual(int[] array, int[] other)
        {
            // Differ in length => easily different arrays
            if (array.Length != other.Length) return false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != other[i]) return false;
            }
            return true;
        }
    }
}
