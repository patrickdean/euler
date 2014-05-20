using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.IO;

namespace Problem_13
{
    class Program
    {
        static List<BigInteger> bigInts = new List<BigInteger>();

        static void Main(string[] args)
        {
            GetIntsFromFile("bigInts.txt");

            BigInteger theBigOne = new BigInteger(0);

            foreach (BigInteger b in bigInts)
                theBigOne += b;

            string bigString = theBigOne.ToString();

            Console.Write("First 10 digits: ");

            for (int i = 0; i < 10; i++)
                Console.Write(bigString[i]);

            Console.WriteLine();
        }

        static void GetIntsFromFile(string filePath)
        {
            StreamReader file = new StreamReader(filePath);

            while (!file.EndOfStream)
            {
                bigInts.Add(BigInteger.Parse(file.ReadLine()));
            }
            
        }
        
    }
}
