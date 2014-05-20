using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            long i = 1;

            for (; i < long.MaxValue; i++)
            {
                if (IsDivisibleByAll(i))
                    break;
            }

            Console.WriteLine(i);
            Console.Read();
        }

        static bool IsDivisibleByAll(long n)
        {
            for (int j = 11; j <= 20; j++)
                if (n % j != 0)
                    return false;
            return true;
        }
    }
}
