using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberGenerator
{
    public static class Prime
    {
        public static Dictionary<long, int> Primes { get; private set; }

        /// <summary>
        /// Generates prime list using the Sieve of Atkin.
        /// </summary>
        /// <param name="maxValue">The maximum value of primes to generate</param>
        public static void SieveOfAtkin(long max)
        {
            //  var isPrime = new BitArray((int)max+1, false); 
            //  Can't use BitArray because of threading issues.
            var isPrime = new bool[max + 1];
            var sqrt = (int)Math.Sqrt(max);

            Parallel.For(1, sqrt, x =>
            {
                var xx = x * x;
                for (int y = 1; y <= sqrt; y++)
                {
                    var yy = y * y;
                    var n = 4 * xx + yy;
                    if (n <= max && (n % 12 == 1 || n % 12 == 5))
                        isPrime[n] ^= true;

                    n = 3 * xx + yy;
                    if (n <= max && n % 12 == 7)
                        isPrime[n] ^= true;

                    n = 3 * xx - yy;
                    if (x > y && n <= max && n % 12 == 11)
                        isPrime[n] ^= true;
                }
            });

            Primes = new Dictionary<long, int>() { { 2, 1 }, { 3, 1 } };

            for (int n = 5; n <= sqrt; n++)
            {
                if (isPrime[n])
                {
                    Primes.Add(n, 1);
                    int nn = n * n;
                    for (int k = nn; k <= max; k += nn)
                        isPrime[k] = false;
                }
            }
            try
            {

                for (int n = sqrt + 1; n <= max; n++)
                    if (isPrime[n])
                        Primes.Add(n, 1);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        /// <summary>
        /// Determines if a number is prime.
        /// </summary>
        /// <param name="number">The number to test for primality</param>
        /// <returns>True if prime, else false.</returns>
        public static bool IsPrime(long number)
        {
            if (Primes.ContainsKey(number))
                return true;

            double squareRoot = Math.Sqrt(number);
            
            if(squareRoot == (int)squareRoot)
                return false;

            foreach (long i in Primes.Keys)
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
