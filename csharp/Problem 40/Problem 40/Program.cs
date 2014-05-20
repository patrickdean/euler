using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_40
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            long answer = 1;
            
            for (int i = 0; number.Length <= 1000000; i++)
            {
                number += i;
            }
            
            for (int i = 1; i <= 1000000; i *= 10)
                answer *= (number[i] - '0');

            Console.WriteLine(answer);
            Console.Read();

        }
    }
}
