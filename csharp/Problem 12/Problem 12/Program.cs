using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using Timer;

namespace Problem_12
{
    class Program
    {
        static int max = 0;

        static void Main(string[] args)
        {
            int divisorCount;
            BigInteger num = 1;
            bool done = false;
            BigInteger triangleNum = 0;
            SimpleTimer.Start();
            while (!done)
            {
                triangleNum = TriangleNumber(num);
                divisorCount = Factorization(triangleNum);
                max = Math.Max(max, divisorCount);

                if (divisorCount > 500)
                    done = true;
                num++;
            }
            SimpleTimer.Stop();

            Console.WriteLine(SimpleTimer.ToString());
            Console.WriteLine("Triangle number: " + triangleNum + " Number: " + (num - 1));
            Console.ReadLine();
        }


        public static int Factorization(BigInteger num)
        {
            int factors = 2;
            double sqrtNum = Complex.Sqrt((Complex)num).Real;
            BigInteger n = num;

            int i = 2;
            while (n != 1 && i < (int)sqrtNum)
            {
                if (num % i == 0)
                {
                    n = num / i;

                    factors += 2;
                }
                i++;
            }

            return factors;
        }

        public static BigInteger TriangleNumber(BigInteger n)
        {
            return n * (n + 1) / 2;
        }
    }
}
