using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_28
{
    class Program
    {
        const int SIZE = 1001;
        static int[,] spiralMatrix = new int[SIZE, SIZE];

        static void Main(string[] args)
        {
            CreateMatrix();

            long sum = FindDiagSum();

            //for (int i = 0; i < SIZE; i++)
            //{
            //    for (int j = 0; j < SIZE; j++)
            //        Console.Write(spiralMatrix[j, i] + " ");
            //    Console.WriteLine();
            //}
            Console.WriteLine("Sum of Diagonals: " + sum);
        }

        static long FindDiagSum()
        {
            long sum = 0;
            int i = 0, j = 0;
            while (i < SIZE)
            {
                sum += (uint)spiralMatrix[i, j];
                i++; j++;
            }

            j = 0; i = SIZE - 1;
            while (j < SIZE)
            {
                sum += (uint)spiralMatrix[i, j];

                j++; i--;
            }

            sum--;

            return sum;
        }

        static void CreateMatrix()
        {
            
            int i = SIZE;
            int j = 0;

            int startR = SIZE-1, startL=0;
            int n = SIZE*SIZE;


            while (n > 0)
            {
                i = startR;
                j = startL;


                // left
                while (i >= startL)
                {
                    spiralMatrix[i, j] = n;
                    n--;
                    i--;
                }
                i = startL;

                j = startL + 1;
                // down
                while (j <= startR)
                {
                    
                    spiralMatrix[i, j] = n;
                    
                    n--;
                    j++;
                }
                j = startR;

                i++;
                // right
                while (i <= startR)
                {
                    
                    spiralMatrix[i, j] = n;
                    
                    n--;
                    i++;
                }
                i = startR;

                j--;
                // up
                while (j > startL)
                {
                    spiralMatrix[i, j] = n;
                    n--;
                    j--;
                }

                startR--;
                startL++;
            }

        }
    }
}
