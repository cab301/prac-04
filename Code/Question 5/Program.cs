namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerCollection customers = new CustomerCollection(5);
            customers.Insert("Dems", "Demecillo", "4547325");
            customers.Insert("Andrey", "Kravets", "23412521");
            customers.Insert("Thanh La", "Tran", "68790472");
            customers.Insert("Dan", "Tran", "123456412");
            customers.Insert("Alexander", "Fritz", "1851234123");
            customers.Display();

            Console.WriteLine("Sorting the customers...");
            customers.Sort();
            customers.Display();

        }
    }
}