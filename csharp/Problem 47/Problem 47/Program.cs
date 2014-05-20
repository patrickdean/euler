using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeNumberGenerator;

namespace Problem_47
{
    class Program
    {
        const int consecutiveValues = 4;

        static void Main(string[] args)
        {
            Prime.SieveOfAtkin(1000000);

            bool done=false;
            int i = 1;
            while (!done)
            {
                i++;
                done = Method(i);
            }

            Console.WriteLine(i);
            Console.Read();
        }

        static bool Method(int num)
        {
            for (int i = num; i < num + consecutiveValues; i++)
                if (DistinctPrimesFactorization(i) != consecutiveValues)
                    return false;
            return true;
        }

        static int DistinctPrimesFactorization(int num)
        {
            List<int> factors = new List<int>();

            foreach (int p in Prime.Primes)
            {
                if (p > num)
                    break;

                if (num % p == 0)
                    factors.Add(p);
            }
            
            return factors.Count;
        }
    }
}
