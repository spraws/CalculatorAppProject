namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Startup sequence
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   _____      _            _       _               _____                                              ___  __ \r\n  / ____|    | |          | |     | |             |  __ \\                                            / _ \\/_ |\r\n | |     __ _| | ___ _   _| | __ _| |_ ___  _ __  | |__) _ __ ___   __ _ _ __ __ _ _ __ ___   __   _| | | || |\r\n | |    / _` | |/ __| | | | |/ _` | __/ _ \\| '__| |  ___| '__/ _ \\ / _` | '__/ _` | '_ ` _ \\  \\ \\ / | | | || |\r\n | |___| (_| | | (__| |_| | | (_| | || (_) | |    | |   | | | (_) | (_| | | | (_| | | | | | |  \\ V /| |_| _| |\r\n  \\_____\\__,_|_|\\___|\\__,_|_|\\__,_|\\__\\___/|_|    |_|   |_|  \\___/ \\__, |_|  \\__,_|_| |_| |_|   \\_/  \\___(_|_|\r\n                                                                    __/ |                                     \r\n                                                                   |___/                                      \r\n\r\n");
            Console.ResetColor();
            //End


            //Class Vriables
            UserInput input1 = new UserInput();
            UserInput input2 = new UserInput();

            //Declaring the calculator options
            Adding add = new Adding();
            Subtract subtract = new Subtract();
            Multiply multiply = new Multiply();
            Divide divison = new Divide();


            do
            {
                Console.WriteLine("Enter your first number");
                input1.Number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your second number");
                input2.Number2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Press 1 to add, 2 to subtract, 3 to multiply or 4 to divide");
                string choice = Console.ReadLine();

                //Execute user input, switch statements here are more efficcient than if statements
                switch (choice)
                {
                    case "1":
                        add.CalculateSum(input1, input2);
                        break;
                    case "2":
                        subtract.SubtractResult(input1, input2);
                        break;
                    case "3":
                        multiply.MultiplyResult(input1, input2);
                        break;
                    case "4":
                        divison.DivisionResult(input1, input2);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option!");
                        break;

                }
                Console.WriteLine("Would you like to continue? Y/N");

            }
            //To upper() ensures it will accept any case the user inputs
            while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");

        }

            
    }
}
