namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerCollection collection = new CustomerCollection(3);
            collection.Display();
            collection.Insert("Jane", "Hoang", "2341235412");
            collection.Insert("Maolin", "Tang", "46123465");
            collection.Insert("Dan", "Tran", "31232143");

            collection.Display();
            Console.WriteLine("Sorting the customers\n");
            collection.Sort();

            collection.Display();
        }
    }
}