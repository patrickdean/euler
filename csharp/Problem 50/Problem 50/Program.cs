using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeNumberGenerator;


namespace Problem_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime.SieveOfAtkin(1000000);

            int biggestPrime = 0;

            List<int> sumList = new List<int>();
            int sumCount = 0;

            foreach (int p in Prime.Primes)
            {
                sumList = new List<int>();
                for (int i = Prime.Primes.IndexOf(p); i < Prime.Primes.Count; i++)
                {
                    sumList.Add(Prime.Primes[i]);

                    if (sumList.Sum() > Prime.Primes.Last())
                        break;

                    int sum = sumList.Sum();

                    if (Prime.Primes.Contains(sum))
                    {
                        if (sumList.Count > sumCount)
                        {
                            biggestPrime = sum;
                            sumCount = sumList.Count;
                        }
                    }
                }
            }
            
            Console.WriteLine(biggestPrime);
            Console.Read();
        }
    }
}
