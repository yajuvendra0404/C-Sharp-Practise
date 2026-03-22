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
            Console.WriteLine("Rectangular Array:");
            int[,] arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } }; // Rectangular array with 2 rows and 4 columns
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Jagged Array:");
            int[][] JaggedArr = new int[4][]; // jagged array with 4 rows, but different number of columns in each row
            JaggedArr[0] = new int[] { 1, 2, 3, 5, 6 };
            JaggedArr[1] = new int[] { 4, 9, 1, 8 };
            JaggedArr[2] = new int[] { 2, 1, 1 };
            JaggedArr[3] = new int[] { 9, 6 };

            foreach (int[] row in JaggedArr)
            {
                foreach (int item in row)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
