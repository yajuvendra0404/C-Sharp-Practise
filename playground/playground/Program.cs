using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground
{

    internal class LifeCycle
    {
        static int breathCount;

        static LifeCycle()
        {
            breathCount = 0;
            LifeCycle.Breath();
        }
        internal void Eat()
        {
            LifeCycle.breathCount++;
            LifeCycle.Breath();
            Console.WriteLine("Eating food...");
        }

        internal void Sleep()
        {
            LifeCycle.breathCount++;
            LifeCycle.Breath();
            Console.WriteLine("Sleeping");
        }

        internal static void Breath() { 

            Console.WriteLine("#### ...Breathing... ####");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            LifeCycle life = new LifeCycle();
            life.Eat();
            life.Sleep();
            LifeCycle.Breath();

        }
    }

}
