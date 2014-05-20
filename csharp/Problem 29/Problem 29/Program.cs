using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_29
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<BigInteger> theNumbers = new SortedSet<BigInteger>();

            
            for(int i = 2; i <= 100; i++)
                for(int j = 2; j<=100; j++)
                    theNumbers.Add(BigInteger.Pow(i,j));

            Console.WriteLine("Distinct Entries: " + theNumbers.Count);
            Console.Read();
        }
    }
}
