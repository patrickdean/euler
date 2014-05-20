using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_355
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CoPrimeSum(10));
        }


        static int GreatestCommonDivisor(int a, int b)
        {
            int r = a % b;
            int d = b;

            while (r > 0)
            {
                int c = d;
                d = r;
                r = c % d;
            }
            
            return d;
        }

        static int CoPrimeSum(int n)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
                numbers.Add(i);

            List<int> sums = new List<int>();
            List<int> set;
            for (int k = n; k >= 1; k--)
            {
                set = new List<int>();
                set.Add(k);
                for (int i = k; i >= 1; i--)
                {
                    bool coprime = true;
                    foreach (int j in set)
                    {
                        if (GreatestCommonDivisor(j, i) != 1 || set.Contains(i))
                            coprime = false;
                    }

                    if (coprime)
                        set.Add(i);
                }

                for (int i = n; i > k; i--)
                {
                    bool coprime = true;
                    foreach (int j in set)
                    {
                        if (GreatestCommonDivisor(j, i) != 1 || set.Contains(i))
                            coprime = false;
                    }

                    if (coprime)
                        set.Add(i);

                }

                sums.Add(set.Sum());
            }

            return sums.Max();
        }
    }
}
