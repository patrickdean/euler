using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7
{
    class Program
    {
        static List<int> primes = new List<int>();

        static void Main(string[] args)
        {
            Timer.Start();
            primes.Add(2);
            primes.Add(3);

            int i = 4;

            while (primes.Count < 10001)
            {
                if (IsPrime(i))
                    primes.Add(i);

                i++;
            }
            Timer.Stop();
            Console.WriteLine(Timer.ToString());

            Console.WriteLine(primes.Last());

        }

        static bool IsPrime(int num)
        {
            double squareRoot = Math.Sqrt(num);

            if (squareRoot == (int)squareRoot)
                return false;

            foreach (int i in primes)
            {
                if (i > squareRoot)
                    break;

                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
