using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_104
{
    class Program
    {
        static BigInteger fib1 = BigInteger.One;
        static BigInteger fib2 = BigInteger.One;
        
        static void Main(string[] args)
        {
            int count = 2;

            while (!IsPanDigital(fib2))
            {
                BigInteger nextFib = fib1 + fib2;
                fib1 = fib2;
                fib1 = fib2;
                fib2 = nextFib;
                count++;
            }

            Console.WriteLine(count);

            Console.ReadLine();

        }

        static public bool IsPanDigital(BigInteger num)
        {
            string numString = num.ToString();

            if (numString.Length < 1000)
                return false;

            string frontString = numString.Substring(0, 9);
            string backString = numString.Substring(numString.Length - 9, 9);
            
            return IsPanDigital(frontString) && IsPanDigital(backString);
        }

        public static bool IsPanDigital(string numString)
        {
            List<int> numList = new List<int>();

            foreach (char c in numString)
            {
                numList.Add((int)Char.GetNumericValue(c));
            }

            numList.Sort();

            for (int i = 0; i < 9;i++)
            {
                if (numList[i] != i + 1)
                    return false;
            }

            return true;
        }
    }
}
