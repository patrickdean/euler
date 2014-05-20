using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_55
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 1; i < 10000; i++)
            {
                if (IsLychreal(i))
                    count++;
            }

            Console.WriteLine(count);
            Console.Read();
        }

        static bool IsAPalindrome(string numString)
        {
            if (numString.Length == 1)
                return true;

            int back = numString.Length - 1;
            int front = 0;

            while (back > front)
            {
                if (!numString[front].Equals(numString[back]))
                    return false;
                back--;
                front++;
            }
            return true;
        }


        static bool IsLychreal(int number)
        {
            BigInteger nextNum = number;

            for (int i = 0; i < 50; i++)
            {
                BigInteger reverse = BigInteger.Parse(Reverse(nextNum.ToString()));

                nextNum = nextNum + reverse;

                if (IsAPalindrome((nextNum).ToString()))
                    return false;
            }

            return true;
        }

        static string Reverse(string str)
        {
            if (str == null) return null;

            // this was posted by petebob as well 
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
