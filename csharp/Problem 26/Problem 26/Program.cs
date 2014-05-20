using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Problem_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime.GeneratePrimes(1000);

            foreach(int i in Prime.Primes)
            {
                if (IsCyclic(i))
                    Console.WriteLine(i);
            }

            
        }

        static BigInteger GetCyclic(int p)
        {
            return ((BigInteger)Math.Pow(10, p - 1) - 1) / p;
        }

        static bool IsCyclic(int p)
        {
            int b = 10;
            int t = 0;
            int r = 1;
            int n = 0;

            do
            {
                t++;
                if (t > (p / 2))
                    return true;

                int x = r * b;
                int d = x / p;
                r = x % p;
                n = n * b + d;

            } while (r != 1);


            return t == p - 1;
        }


        /// <summary>
        /// Assigns repeated digits to repeatedDigits, if the digitSequence matches the pattern
        /// </summary>
        /// <returns>true if success, false otherwise</returns>
        public static bool TryGetRepeatedDigits(string digitSequence, out string repeatedDigits)
        {
            repeatedDigits = null;

            string pattern = @"^\d*(?<repeat>\d+)\k<repeat>+\d*$";

            if (Regex.IsMatch(digitSequence, pattern))
            {
                Regex r = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                repeatedDigits = r.Match(digitSequence).Result("${repeat}");
                return true;
            }
            else
                return false;
        }
    }
}
