using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;
            int n = 1;
            long sumSquares = 0, squareSums = 0;
            
            while (n <= MAX)
            {
                sumSquares += n * n;
                squareSums += n;

                n++;
            }

            squareSums *= squareSums;

            long diff = squareSums - sumSquares;

            Console.WriteLine("Difference: " + diff);

        }
    }
}
