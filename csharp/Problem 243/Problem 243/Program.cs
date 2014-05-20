using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_243
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 65360;
            int j = 173224;
            int h = 1322500;
            double breakValue = 1.0;
            double breakCondition = 15499.0 / 94744.0;

            while (breakValue > breakCondition)
            {
                j += 2;
                int count = 0;
                for (int i = 1; i < j; i++)
                {
                    if (IsReslient(i, j))
                        count++;

                    breakValue = (double)count / (j - 1.0);

                    if (breakValue > breakCondition)
                        break;
                }

             //   breakValue = (double)count / (j - 1.0);

            }

            Console.WriteLine(j);
            Console.Read();
        }


        static bool IsReslient(int numerator, int denominator)
        {
            return GreatestCommonDivisor(numerator, denominator) == 1;
        }


        static int GreatestCommonDivisor(int a, int b)
        {
            int r = a % b;
            int d = b;

            while (r > 0)
            {
                int c = d;
                d = r;
                r = c % d;
            }

            return d;
        }
    }
}
