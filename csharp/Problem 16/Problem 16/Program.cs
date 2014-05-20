using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger theNumber = BigInteger.Pow(2, 1000);

            string numString = theNumber.ToString();

            int sum = 0;

            foreach (char c in numString)
                sum += (int)Char.GetNumericValue(c);

            Console.WriteLine("The sum of digits: " + sum);
            Console.Read();
        }
    }
}
