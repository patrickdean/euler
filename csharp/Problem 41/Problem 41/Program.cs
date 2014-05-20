using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeNumberGenerator;

namespace Problem_41
{
    class Program
    {
        static string[] pandigitalStrings = new string[10];

        static void Main(string[] args)
        {
            GeneratePandigitalStrings();
            Prime.SieveOfAtkin(100000000);
            int answer = 0;
            Prime.Primes.Reverse();

            foreach (int p in Prime.Primes)
            {
                if (IsPandigital(p.ToString()))
                {
                    answer = p;
                    break;
                }
            }

            Console.WriteLine(answer);
            Console.Read();
        }

        static bool IsPandigital(string number)
        {
            foreach (char c in pandigitalStrings[number.Length])
            {
                if (!number.Contains(c))
                    return false;
            }

            return true;
        }

        static void GeneratePandigitalStrings()
        {
            for (int i = 1; i < 10; i++)
            {
                pandigitalStrings[i] = "";
                for (int j = 1; j <= i; j++)
                {
                    pandigitalStrings[i] += j;
                }
            }
        }
    }
}
