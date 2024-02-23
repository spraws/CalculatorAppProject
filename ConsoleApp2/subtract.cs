using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Subtract
    {
        public void SubtractResult(UserInput pInput1, UserInput pInput2)
        {
            double no1 = pInput1.Number1;
            double no2 = pInput2.Number2;
            double sum = no1 - no2;

            Console.WriteLine("The subtracted sum of your numbers is {0}", sum);
        }

    }
}
