using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxTerms = 0;
            int theNumber = 0;

            for (int i = 1; i < 1000000; i++)
            {
                int terms = CollatzChain(i);
                if (terms >= maxTerms)
                {
                    maxTerms = terms;
                    theNumber = i;
                }
                
            }

            Console.WriteLine("The Number: " + theNumber + "  Terms: " + maxTerms);
            Console.Read();
        }

        static int CollatzChain(int num)
        {
            int terms = 0;
            long number = num;
            while (number != 1)
            {
                if (number % 2 == 0)
                    number /= 2;
                else
                    number = 3 * number + 1;
                terms++;
            }

            return terms;
        }
    }
}
