using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_80
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfDigits = 0;
            
            for (int i = 2; i < 100; i++)
            {
                double sqrt = Math.Sqrt(i);
                if (sqrt != (int)sqrt)
                {
                    sumOfDigits += DigitalSum(SquareRoot(i));
                }
            }

            Console.WriteLine(sumOfDigits);
            Console.Read();
        }


        public static int DigitalSum(BigInteger number)
        {
            string numStr = number.ToString();
            int sum = 0;
            for(int i = 0; i <100;i++)
                sum += numStr[i] - '0';

            return sum;
        }

        public static BigInteger SquareRoot(int number)
        {
            BigInteger a = 5 * number;
            BigInteger b = 5;

            while (b.ToString().Length < 102)
            {
                if (a >= b)
                {
                    a -= b;
                    b += 10;
                }
                else
                {
                    a *= 100;
                    b = ((b - 5) * 10) + 5;
                }
            }
            return b;
        }
    }
}
