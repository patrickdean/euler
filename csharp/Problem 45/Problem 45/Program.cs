using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_45
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> pentagons = new List<long>();
            List<long> hexagons = new List<long>();

            for (int i = 144; i < 100000; i++)
            {
                pentagons.Add(PentagonalNumber(i));
                hexagons.Add(HexagonalNumber(i));
            }

            long j = 0;

            foreach(int i in hexagons)
                if (pentagons.Contains(i))
                {
                    j = i;
                    break;
                }

            Console.WriteLine(j);
            Console.Read();
        }

        static long PentagonalNumber(long number)
        {
            return number * (3 * number - 1) / 2;
        }
        
        static long HexagonalNumber(long number)
        {
            return number * (2 * number - 1);
        }

    }
}
