using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeNumberGenerator;

namespace Problem_46
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime.SieveOfAtkin(1000000);


            for (int i = 9; i < Prime.Primes.Last(); i += 2)
            {
                if (!GoldbachHypothesis(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }


            Console.Read();
        }


        static bool GoldbachHypothesis(int number)
        {
            if (Prime.Primes.Contains(number))
                return true;

            foreach (int p in Prime.Primes)
            {
                if (p > number)
                    break;

                double sqrt = Math.Sqrt((number - p) / 2);

                if (sqrt == (int)sqrt)
                    return true;
            }

            return false;
        }
    }
}
