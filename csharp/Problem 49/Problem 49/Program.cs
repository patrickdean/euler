using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeNumberGenerator;

namespace Problem_49
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime.SieveOfAtkin(10000);

            foreach (int p in Prime.Primes)
            {
                if (p < 1000)
                    continue;

                for (int i = Prime.Primes.IndexOf(p) + 1; i < Prime.Primes.Count; i++)
                {
                    int diff = Prime.Primes[i] - p;
                    if (Prime.IsNumPrime(Prime.Primes[i] + diff) && IsPermutation(p, diff))
                    {
                        Console.WriteLine("Prime 1: " + p + " Prime 2: " + Prime.Primes[i] + " Prime 3: " + (Prime.Primes[i] + diff) + " Diff: " + diff);
                    }
                }
                
            }
        }

        static bool IsPermutation(int prime1, int diff)
        {
            string primeTwo = (prime1 + diff).ToString();
            string primeThree = (prime1 + diff + diff).ToString();

            string primeOne = prime1.ToString();

            foreach (char c in primeOne)
                if (!primeThree.Contains(c) || !primeTwo.Contains(c))
                    return false;
            foreach (char c in primeTwo)
                if (!primeOne.Contains(c) || !primeThree.Contains(c))
                    return false;
            foreach (char c in primeThree)
                if (!primeOne.Contains(c) || !primeTwo.Contains(c))
                    return false;

            return true;
        }
    }
}
