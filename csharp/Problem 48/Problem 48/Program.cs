using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_48
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger sum = new BigInteger();
            BigInteger bigInt = new BigInteger();
            const int SIZE = 1000;

            for (int i = 1; i <= SIZE; i++)
            {
                bigInt = BigInteger.Pow(i, i);

                sum += bigInt;
            }

            string sumString = sum.ToString();

            string lastTen = sumString.Substring((sumString.Length - 10));

            Console.WriteLine("Last 10 digits: " + lastTen);
        }
    }
}
