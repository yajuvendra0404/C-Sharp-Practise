using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("### Calculator ###");

            Console.WriteLine("Enter A = ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B = ");
            int val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(@"What operation do you want to perform?
            A. Addition.
            B. Subraction.
            C. Multiplication.
            D. Division.
            ");

            string selection = Console.ReadLine();

            Operation op = new Operation(val1, val2);

            if (selection == "A")
            {
                op.add();
            }
            else if (selection == "B")
            {
                op.subtract();
            }
            else if (selection == "C")
            {
                op.multiply();
            }
            else if (selection == "D")
            {
                op.divide();
            }
            else
            {
                Console.WriteLine("Wrong selection");
            }

        }
    }
}
