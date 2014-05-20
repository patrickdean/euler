using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> theNumber = new List<int>();

            StreamReader file = new StreamReader("number.txt");

            int z;

            while (!file.EndOfStream)
            {
                string num = ((char)file.Read()).ToString();
                if (int.TryParse(num, out z))
                    theNumber.Add(z);

            }

            int largestProduct = 0;

            for (int i = 0; i < theNumber.Count - 4; i++)
            {
                int product = theNumber[i] * theNumber[i + 1] * theNumber[i + 2] * theNumber[i + 3] * theNumber[i + 4];

                if (product > largestProduct)
                    largestProduct = product;
            }

            Console.WriteLine("Largest Product: " + largestProduct);
        }
    }
}
