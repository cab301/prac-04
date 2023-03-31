namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.TestSortRandomArray();
            Test.TestAlreadySortedArray();
            Test.TestInverseSortedArray();
            Test.TestSortEmptyArray();
        }

        public static void Sort(int[] array)
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