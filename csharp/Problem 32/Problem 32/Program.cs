using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_32
{
    class Program
    {
        static string pandigitalString = "123456789";
        static List<int> products = new List<int>();


        static void Main(string[] args)
        {
            for (int i = 1; i < 10000; i++)
                for (int j = 1; j < 10000; j++)
                {
                    int product = i * j;

                    if (product > 1000 && product < 10000)
                    {
                        if (!products.Contains(product) && IsPandigital(i.ToString() + j.ToString() + product.ToString()))
                            products.Add(product);
                    }

                }

            Console.WriteLine(products.Sum());
            Console.Read();
        }

        static bool IsPandigital(string number)
        {
            foreach (char c in pandigitalString)
            {
                if (!number.Contains(c))
                    return false;
            }

            return true;
        }
    }
}
