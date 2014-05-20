using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_30
{
    class Program
    {
        static void Main(string[] args)
        {
            long total = 0;

            for (int i = 2; i < 1000000; i++)
            {
                int sumOfFifth = SumOfFifthPower(i);
                if (sumOfFifth == i)
                    total += i;
            }
            Console.WriteLine(total);
        }


        static int SumOfFifthPower(int number)
        {
            int[] digits = GetDigitArray(number);
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
                sum += (int)Math.Pow(digits[i], 5);
            
            return sum;
        }


        static int[] GetDigitArray(int number)
        {
            int length = number.ToString().Length;
            int[] digits = new int[length];

            for (int i = length - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }

    }
}
