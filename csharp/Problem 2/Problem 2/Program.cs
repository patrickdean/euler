using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Timer;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long fib = 1;
            long lastFib = 0;
            long sum = 0;

            const long MAX = 4000000;
            
            SimpleTimer.Start();
            while (fib < MAX)
            {
                if (fib % 2 == 0)
                {
                    sum += fib;
                }

                fib += lastFib;

                lastFib = fib - lastFib;
            }
            SimpleTimer.Stop();
            
            Console.WriteLine(SimpleTimer.ToString());

            Console.WriteLine("Sum is: " + sum);
        }

        static long Fibonacci(int n)
        {
            if (n == 1 || n == 0)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
