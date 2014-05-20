using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_206
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            BigInteger max = 1929394959697989990;
            BigInteger min = 1020304050607080900;
            
            BigInteger number = (BigInteger)(Complex.Sqrt((Complex)min).Real);

            Console.WriteLine(Evaluate(max.ToString()));
            Console.WriteLine(Evaluate(min.ToString()));

            for (; BigInteger.Pow(number, 2) < max; number++)
            {
                if (Evaluate(BigInteger.Pow(number, 2).ToString()))
                    break;
            }

            DateTime end = DateTime.Now;

            TimeSpan diff = end - start;

            Console.WriteLine(diff.ToString());
            Console.WriteLine("Minutes: " + diff.Minutes);
            Console.WriteLine("Seconds: " + diff.Seconds);
            Console.WriteLine("Ms: " + diff.Milliseconds);

            Console.WriteLine(number);
            Console.Read();
        }


        static bool Evaluate(string num)
        {
            if (num[0] == '1' && num[2] == '2' && num[4] == '3' && num[6] == '4' && num[8] == '5' && num[10] == '6' && num[12] == '7' && num[14] == '8' && num[16] == '9' && num[18] == '0')
                return true;

            return false;
        }

    }
}
