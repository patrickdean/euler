using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeNumberGenerator;
using Timer;

namespace Problem_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime.GeneratePrimes(1000000);
            int circularPrimes = 0;

            SimpleTimer.Start();
            foreach (long l in Prime.Primes)
            {
                if (IsCircular(l))
                    circularPrimes++;
            }
            SimpleTimer.Stop();

            Console.WriteLine(SimpleTimer.ToString());
            Console.WriteLine(circularPrimes);
            Console.Read();
        }


        static bool IsCircular(long num)
        {
            if (num < 10)
                return true;
            string numString = num.ToString();

            foreach (char c in numString)
                if ((int)c % 2 == 0)
                    return false;

            long number;
            do
            {
                numString = Rotate(numString);

                number = long.Parse(numString);

                if (!Prime.Primes.Contains(number))
                    return false;
            } while (number != num);

            return true;
        }

        static string Rotate(string s)
        {
            if(s.Length==1)
                return s;

            string newString = s.Substring(1) + s[0];
            
            return newString;
        }
    }
}
