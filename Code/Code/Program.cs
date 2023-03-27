namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CASE 1: Random Array
            int[] randomArray = { 1, 4, 2, 3, 5, 6, 9, 7, 8, 10 };
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            TestSort(randomArray, expectedResult);

            // CASE 2: Already sorted array
            int[] alreadySortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            TestSort(alreadySortedArray, expectedResult);

            // CASE 3: Reversely sorted array
            int[] reverselySortedArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            TestSort(reverselySortedArray, expectedResult);

            // CASE 4: Empty array
            int[] emptyArray = { };
            int[] expectedEmptyArray = { };
            TestSort(emptyArray, expectedEmptyArray);
        }

        // Test the Insertion Sort algorithm. This will compare the expected result
        // against the actual result and display PASS or FAIL
        static void TestSort(int[] input, int[] expectedResult)
        {
            Console.WriteLine("The test input is:");
            DisplayArray(input);
            Console.WriteLine("The expected result is:");
            DisplayArray(expectedResult);
            // Obtain actual result
            BubbleSort(input);
            Console.WriteLine("The actual result is:");
            DisplayArray(input);
            Console.WriteLine(CompareArrays(input, expectedResult) ? "PASS" : "FAIL");
        }

        // Check if all elements in the first array is the same as
        // the elements in the second array.
        // This is because we can't compare by reference
        static bool CompareArrays(int[] firstArray, int[] secondArray)
        {
            // If different lengths, different arrays
            if (firstArray.Length != secondArray.Length) return false;
            // Otherwise, match element-wise
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i]) return false;
            }
            return true;
        }
        // Display all elements in an array
        static void DisplayArray(int[] input) { 
            foreach (int element in input)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
        }

        static void InsertionSort(int[] array)
        {
            for (int i = 1; i <= array.Length - 1; i++)
            {
                int v = array[i];
                int j = i - 1;
                while (j >= 0 &&
                    array[j] > v)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = v;
            }
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i <= n - 2; i++)
            {
                for (int j = 0; j <= n - 2 - i; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        Swap(ref array[j + 1], ref array[j]);
                    }
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}