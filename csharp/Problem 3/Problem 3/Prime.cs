using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3
{
    public static class Prime
    {
        public static List<long> primes = new List<long>();

        public static void GeneratePrimes(long number)
        {
            primes.Add(2);
            primes.Add(3);

            int num = (int)Math.Sqrt(number);

            int i = 4;

            while (i <= num)
            {
                if (IsPrime(i))
                    primes.Add(i);

                i++;
            }

         //   Console.WriteLine(primes.Last());

        }

        static bool IsPrime(int num)
        {
            double squareRoot = Math.Sqrt(num);
            
            if(squareRoot == (int)squareRoot)
                return false;

            foreach (long i in primes)
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
