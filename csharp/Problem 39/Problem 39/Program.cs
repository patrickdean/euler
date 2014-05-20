using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_39
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> triangles = new Dictionary<int, int>();

            for (int p = 3; p < 1000; p++)
            {
                triangles.Add(p, 0);
                for (int a = 1; a < p; a++)
                    for (int b = 1; b < p; b++)
                    {
                        if (a + b > 1000)
                            break;

                        int c = p - a - b;

                        if ((a * a + b * b) == c * c)
                        {
                            triangles[p]++;
                        }
                    }
            }

            Console.WriteLine(triangles.Aggregate((l, r) => l.Value > r.Value ? l : r).Key);
            Console.Read();
        }
    }
}
