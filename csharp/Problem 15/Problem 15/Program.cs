using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace Problem_15
{
    class Program
    {
        
        const int xSize = 20;
        const int ySize = 20;

        static int[,] grid = new int[xSize, ySize];

        static void Main(string[] args)
        {
           // int routes = TraverseGrid(0, 0);

            BigInteger routes = Combination(xSize * 2, ySize);

            Console.WriteLine("Number of Routes: " + routes);
            
            Console.Read();
        }


        // Works, but extremely inefficient. 
        static int TraverseGrid(int i, int j)
        {
            if (i >= xSize && j >= ySize)
                return 1;
            else if (i >= xSize)
                return TraverseGrid(i, j + 1);
            else if (j >= ySize)
                return TraverseGrid(i + 1, j);

            return TraverseGrid(i + 1, j) + TraverseGrid(i, j + 1);
        }


        static BigInteger Combination(int n, int r)
        {
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

        static BigInteger Factorial(int n)
        {
            BigInteger num = 1;

            for (int i = n; i > 0; i--)
                num *= i;
            return num;
        }
    }
}
