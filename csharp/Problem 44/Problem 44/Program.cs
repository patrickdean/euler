using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_44
{
    class Program
    {
        static List<long> numbers = new List<long>();
        
        static void Main(string[] args)
        {
            
            long diff = long.MaxValue;


            for (int i = 1; i <= 100000; i++)
                numbers.Add(PentagonalNumber(i));

            bool found = false;

            foreach (long p in numbers)
            {

                for (int i = numbers.IndexOf(p) + 1; i < numbers.Count; i++)
                {

                    if (IsPentagonal(numbers[i] - p) && IsPentagonal(numbers[i] + p))
                    {
                        diff = numbers[i] - p;
                        found = true;
                        break;
                    }
                }
                if (found)
                    break;

            }


            Console.WriteLine(diff);
            Console.Read();
        }

        static bool IsPentagonal(long num)
        {
            return numbers.BinarySearch(num) >= 0;
        }

        static long PentagonalNumber(long number)
        {
            return number * (3 * number - 1) / 2;
        }
    }
}
