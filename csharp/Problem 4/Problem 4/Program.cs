using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = 0;

            for (int i = 100; i < 1000; i++)
                for (int j = 100; j < 1000; j++)
                    largest = i * j > largest && (IsAPalindrome(i * j)) ? i * j : largest;

            Console.WriteLine("The number: " + largest);
        }

        static bool IsAPalindrome(int num)
        {
            string numString = num.ToString();

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
    }
}
