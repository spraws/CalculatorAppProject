namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int no1;
            int no2;
            int choice;

            Console.WriteLine("Enter a number!");
            no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number");
            no2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press 1 to add, 2 to multiply, 3 to subtract or 4 to divide");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                int value;
                value = no1 + no2;
                Console.WriteLine(value);
            }
            if (choice == 2)
            {
                int value;
                value = no1 * no2;
                Console.WriteLine(value);
            }
            if (choice ==3)
            {
                int value;
                value = no1 - no2;
                Console.WriteLine(value);
            }
            if(choice == 4)
            {
                int value;
                value = no1 / no2;
                Console.WriteLine(value);
            }
        }
    }
}
