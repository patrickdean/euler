using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime.GeneratePrimes(2000000);

            long sum = 0;

            foreach (long i in Prime.Primes)
            {
                sum += i;
            }

            Console.WriteLine("Sum: " + sum);
            Console.Read();
        }
    }
}
