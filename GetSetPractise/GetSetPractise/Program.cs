using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GetSetPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.MakeYear = 2001;
            obj.Engine = "v8";
            obj.Type = "Sedan";
            obj.Name = "Mazda";
            string car = obj.GetCar();
            Console.WriteLine(car);
        }
    }
}
