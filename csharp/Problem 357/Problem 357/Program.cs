using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading;
using PrimeNumberGenerator;
using Timer;

namespace Problem_357
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime.SieveOfAtkin(110000000);
            List<long> numbers = new List<long>() { 1 };

            Console.WriteLine(IsPrimeGenerating(30));
            Console.WriteLine(IsPrimeGenerating(2));
            Console.WriteLine(IsPrimeGenerating(100000000));

            foreach (long i in Prime.Primes.Keys)
            {
                if (i > 100000000)
                    break;

                if (IsPrimeGenerating(i - 1))
                    numbers.Add(i - 1);
            }

            BigInteger sumber = 0;

            foreach (int num in numbers)
                sumber += num;

            Console.WriteLine(sumber);
            Console.Read();
        }

        public static bool IsPrimeGenerating(long number)
        {
            double sqrt = Math.Sqrt(number);

            if (sqrt == (int)sqrt)
                if (!Prime.Primes.ContainsKey((int)sqrt))
                    return false;

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    long trial = i + number / i;
                    if (!Prime.Primes.ContainsKey(trial))
                        return false;
                }
            }
            return true;
        }
    }
}
