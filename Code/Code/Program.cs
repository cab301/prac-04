namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.TestSortRandomArray();
            Test.TestSortRandomArrayRepeated();
            Test.TestSortAlreadySortedArray();
            Test.TestSortInvertedArray();
            Test.TestSortEmptyArray();
        }


        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i <= array.Length - 1; i++)
            {
                int v = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > v)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = v;
            }
        }
    }
}