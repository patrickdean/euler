using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_36
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;

            for (int i = 0; i < 1000000; i++)
            {
                if (IsAPalindrome(i.ToString()) && IsAPalindrome(Convert.ToString(i, 2)))
                    sum += i;
            }

            Console.WriteLine(sum);
        }

        static bool IsAPalindrome(string s)
        {
            int back = s.Length - 1;
            int front = 0;

            while (back > front)
            {
                if (!s[front].Equals(s[back]))
                    return false;
                back--;
                front++;
            }
            return true;
        }

    }
}
