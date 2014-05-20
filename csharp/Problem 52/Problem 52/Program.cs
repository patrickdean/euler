using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_52
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            for (int i = 100000; i < 200000; i++)
            {
                if (IsPermutation(i))
                    answer = i;
            }
            Console.WriteLine(answer);
            Console.Read();
        }

        static bool IsPermutation(int num)
        {
            string[] numbers = new string[6];

            for (int j = 1; j <= 6; j++)
                numbers[j - 1] = (num * j).ToString();

            foreach (string s in numbers)
            {
                foreach (string n in numbers)
                {
                    if (n == s)
                        continue;
                    foreach (char c in n)
                    {
                        if (!s.Contains(c))
                            return false;
                    }
                }
            }
            
            return true;
        }
    }
}
