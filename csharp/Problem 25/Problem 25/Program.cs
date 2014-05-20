using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_25
{
    class Program
    {
        static BigInteger fib1 = BigInteger.One;
        static BigInteger fib2 = BigInteger.One;
        static BigInteger count = 2;

        static void Main(string[] args)
        {
            while (fib2.ToString().Length < 1000)
            {
                BigInteger nextFib = fib1 + fib2;

             //   Console.WriteLine(fib2.ToString());

                fib1 = fib2;
                fib2 = nextFib;
                count++;
            }

            Console.WriteLine("The {0}th fibonacci term is 1000 digits or more", count);
            Console.WriteLine(fib2.ToString());
            Console.WriteLine(fib2.ToString().Length);
            Console.ReadLine();
        }
    }
}
