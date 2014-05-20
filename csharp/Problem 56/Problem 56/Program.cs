using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_56
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger theBigOne = 0;
            BigInteger biggestSum = 0;

            for(int i = 1; i < 100; i++)
                for (int j = 1; j < 100; j++)
                {
                    theBigOne = BigInteger.Pow(i, j);
                    BigInteger bigSum = SumOfDigits(theBigOne);
                    biggestSum = bigSum > biggestSum ? bigSum : biggestSum;
                }

            Console.WriteLine(biggestSum);
            Console.Read();
        }

        static BigInteger SumOfDigits(BigInteger big)
        {
            string bigInt = big.ToString();
            BigInteger sum = 0;

            foreach (char c in bigInt)
            {
                sum += c - '0';
            }
            return sum;
        }
    }
}
