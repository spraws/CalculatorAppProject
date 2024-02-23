using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Divide
    {

        public void DivisionResult(UserInput pInput1, UserInput pInput2)
        {
            int no1 = pInput1.Number1;
            int no2 = pInput2.Number2;
            int sum = no1 / no2;

            Console.WriteLine("Your numbers divided are {0}", sum);

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Your numbers divided are {0}", sum);
            //Console.ResetColor();
        }

    }
}
