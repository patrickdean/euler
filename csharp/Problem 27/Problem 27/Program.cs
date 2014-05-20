using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeNumberGenerator;

namespace Problem_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime.GeneratePrimes(10001);

            int longest = 0;
            int maxI = 0;
            int maxJ = 0;



            for (int i = -999; i < 1000; i++)
                for (int j = -999; j < 1000; j++)
                {
                    int temp = TestQuadradic(i, j);
                    if (temp > longest)
                    {
                        longest = temp;
                        maxI = i;
                        maxJ = j;
                    }
                }

            Console.WriteLine((maxI * maxJ) + " length: " + longest);
        }

        static int TestQuadradic(int a, int b)
        {
            int i = 0;
            while (Prime.IsPrime(Quadratic1(i, a, b)))
                i++;

            return i;
        }

        static int Quadratic1(int n, int a, int b)
        {
            return (n * n + a * n + b);
        }
    }
}
