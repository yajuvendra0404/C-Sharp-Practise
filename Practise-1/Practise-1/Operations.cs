using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_1
{
    internal class Operation
    {
        private int a, b, c;
        internal Operation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        internal void add()
        {
            Console.WriteLine("addition" + (a + b));
        }
        internal void subtract()
        {
            Console.WriteLine("subtraction" + (b - a));
        }
        internal void divide()
        {
            Console.WriteLine("division" + (b / a));
        }
        internal void multiply()
        {
            Console.WriteLine("multiplication" + (a * b));
        }
    }
}
