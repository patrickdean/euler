using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_38
{
    class Program
    {
        static string pandigitalString = "123456789";

        static void Main(string[] args)
        {
            int largest = 0;

            for (int i = 1; i < 1000000; i++)
            {
                string number = i.ToString();

                for (int j = 2; j < 10; j++)
                {
                    int next = i * j;
                    number += next.ToString();

                    if (number.Length > 9)
                        break;
                    else if (number.Length == 9)
                    {
                        if (IsPandigital(number))
                            largest = int.Parse(number) > largest ? int.Parse(number) : largest;
                    }

                }
            }

            Console.WriteLine(largest);
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
