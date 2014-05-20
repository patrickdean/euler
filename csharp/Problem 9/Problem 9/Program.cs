using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 500; i++)
                for (int j = 1; j < 500; j++)
                    for (int k = 1; k < 500; k++)
                    {
                        if (i * i + j * j == k * k && (i + j + k == 1000))
                        {
                            Console.WriteLine("i: " + i + " i^2: " + (i * i) + " j: " + j + " j^2: " + (j * j) + " k: " + k + " k^2: " + (k * k) + " ijk: " + (i + j + k));
                            
                        }
                    }


        }
    }
}
