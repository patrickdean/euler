using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_97
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigInteger theBigOne = 1;// 28433 * BigInteger.Pow(2, 7830457) + 1;
            long num = 1;

            for (int i = 0; i < 7830457; i++)
            {
                num <<= 1;
                num %= 10000000000;
            }

            num *= 28433;
            num %= 10000000000;
            num++;

            Console.WriteLine(num);
            Console.Read();
        }

        public static string lastTen(String str)
        {
            return str.Substring(str.Length - 10, 10);

        }
    }
}
