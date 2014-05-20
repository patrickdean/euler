using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_53
{
    class Program
    {
        const int limit = 1000000;

        static void Main(string[] args)
        {
            int answer = 0;


            for (int i = 1; i <= 100; i++)
                for (int j = 1; j <= i; j++)
                    if (Combination(i, j) > limit)
                        answer++;


            Console.WriteLine(answer);
        }

        static BigInteger Combination(int n, int r)
        {
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

        static BigInteger Factorial(int n)
        {
            BigInteger num = 1;

            for (int i = n; i > 0; i--)
                num *= i;
            return num;
        }
    }
}
