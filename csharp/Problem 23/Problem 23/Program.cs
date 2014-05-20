using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_23
{
    class Program
    {
        static BigInteger sum = BigInteger.Zero;

        static void Main(string[] args)
        {
            

            for (int i = 1; i < 28124; i++)
            {
                if (!CanBeWrittenAsTwoAbundants(i))
                    sum += i;

         //       Console.WriteLine("Divisor sum of {0}: {1}  {2}", i, divisorSum(i), CanBeWrittenAsTwoAbundants(i).ToString());
            }


            Console.WriteLine("The sum is: {0}", sum);

            Console.ReadLine();

        }


        static bool CanBeWrittenAsTwoAbundants(int number)
        {
            int num1 = 1;
            int num2 = number - 1;

            while (num1 <= num2)
            {
                if (IsAbundant(num1) && IsAbundant(num2))
                    return true;

                num1++; num2--;
            }

            return false;
        }

        static bool IsAbundant(int number)
        {
            int divisorSum = Factorization(number);
            
            return (divisorSum > number);
        }

        public static int Factorization(int num)
        {
            List<int> factors = new List<int>();
            int n = num;
            int i = 2;
            factors.Add(1);
            
            while (n != 1 && i < (int)Math.Sqrt(num))
            {
                if (num % i == 0)
                {
                    n = num / i;
                    if (!factors.Contains(i))
                        factors.Add(i);
                    if (!factors.Contains(n))
                        factors.Add(n);
                }
                i++;
            }

            return factors.Sum();
        }



        static int divisorSum(int number)
        {
            List<int> divisors = new List<int>();

            for (int i = 1; i <= number / 2; i++)
                if (number % i == 0)
                    divisors.Add(i);

            int divisorSum = 0;

            foreach (int i in divisors)
                divisorSum += i;

            return divisorSum;
        }
    }
}
