using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } }; // Rectangular array with 2 rows and 4 columns
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
