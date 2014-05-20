using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
        
            long theNumber = 600851475143;
            long number2 = 317584931803;
            //long largestPrimeFactor = 1;

            //Prime.GeneratePrimes(theNumber);

            //foreach (long i in Prime.primes)
            //{
            //    if (theNumber % i == 0)
            //        largestPrimeFactor = i;
            //}

        //    Console.WriteLine("Largest Prime Factor: " + largestPrimeFactor);
            Console.WriteLine(LargestPrimeFactor(theNumber));
            Console.WriteLine(LargestPrimeFactor(number2));

            Console.Read();
        }

        static long LargestPrimeFactor(long number)
        {
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                    number /= i;
                else
                    i++;
            }

            return number;
        }

    }
}
