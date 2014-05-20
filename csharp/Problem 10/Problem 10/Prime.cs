using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_10
{
    public static class Prime
    {
        public static List<long> Primes = new List<long>();

        public static void GeneratePrimes(long num)
        {
            Primes.Add(2);
            Primes.Add(3);
                       

            int i = 4;

            while (i <= num)
            {
                if (IsPrime(i))
                    Primes.Add(i);

                i++;
            }

         //   Console.WriteLine(primes.Last());

        }

        static bool IsPrime(int num)
        {
            double squareRoot = Math.Sqrt(num);
            
            if(squareRoot == (int)squareRoot)
                return false;

            foreach (long i in Primes)
            {
                if (i > squareRoot)
                    break;

                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
