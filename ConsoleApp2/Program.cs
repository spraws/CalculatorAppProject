namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInput input1 = new UserInput();
            UserInput input2 = new UserInput();

            Adding add = new Adding();
            Subtract subtract = new Subtract();
            Multiply multiply = new Multiply();
            Divide divison = new Divide();

            string choice;

            Console.WriteLine("Enter your first number");
            input1.Number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            input2.Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press 1 to add, 2 to subtract, 3 to multiply or 4 to divide");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                add.CalculateSum(input1, input2);
            }

            if (choice == "2")
            {
                subtract.SubtractResult(input1, input2);
            }

            if (choice == "3") 
            {
                multiply.MultiplyResult(input1, input2);
            }

            if (choice == "4")
            {
                divison.DivisionResult(input1, input2);
            }


        }

            
    }
}
