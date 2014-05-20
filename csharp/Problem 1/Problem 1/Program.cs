using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Timer;

namespace Problem_1
{
    class Program
    {
        const long MAX = 1000000;

        static void Main(string[] args)
        {
            long n = 0;
            long sum = 0;
            SimpleTimer.Start();
            while (n < MAX)
            {
                if (n % 5 == 0 || n % 3 == 0)
                    sum += n;
                n++;
            }
            SimpleTimer.Stop();
            Console.WriteLine(SimpleTimer.ToString());
            Console.Out.WriteLine("Sum is: " + sum);

            SimpleTimer.Start();
            sum = SumDivisibleBy(5) + SumDivisibleBy(3) - SumDivisibleBy(15);
            SimpleTimer.Stop();

            Console.WriteLine(SimpleTimer.ToString());
            Console.Out.WriteLine("Sum is: " + sum);
        }

        static long SumDivisibleBy(int n)
        {
            long p = (MAX - 1) / n;
            return n * (p * (p + 1)) / 2;
        }
    }
}
