using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumberGenerator
{
    public static class Prime
    {
        public static List<long> Primes { get; private set; }

        /// <summary>
        /// Generates prime list up to a maximum number.
        /// </summary>
        /// <param name="numberOfPrimes">The number of primes to generate.</param>
        public static void GeneratePrimes(long numberOfPrimes)
        {
            Primes = new List<long>();
            Primes.Add(2);
            Primes.Add(3);

            int i = 4;
            while (i <= numberOfPrimes)
            {
                if (IsPrime(i))
                    Primes.Add(i);
                i++;
            }
        }

        /// <summary>
        /// Determines if a number is prime.
        /// </summary>
        /// <param name="number">The number to test for primality</param>
        /// <returns>True if prime, else false.</returns>
        public static bool IsPrime(int number)
        {
            double squareRoot = Math.Sqrt(number);
            
            if(squareRoot == (int)squareRoot)
                return false;

            foreach (long i in Primes)
            {
                if (i > squareRoot)
                    break;

                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
