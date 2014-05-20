using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace Problem_20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger nFactorial = new BigInteger();
            
            nFactorial = Factorial(100);

            string number = nFactorial.ToString();

            int sumOfNumbers = 0;

            foreach (char c in number)
                sumOfNumbers += int.Parse(c.ToString());

            Console.WriteLine("Sum of numbers: " + sumOfNumbers);
        }

        static BigInteger Factorial(ulong n)
        {
            BigInteger fact = new BigInteger(1);

            while (n > 0)
            {
                fact *= n;

                n--;
            }

            return fact;
        }
    }
}
