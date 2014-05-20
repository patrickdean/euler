using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem_81
{
    
    class Program
    {
        const int width = 80;
        const int height = 80;
        static SortedList<int, int> values = new SortedList<int, int>();
        static int[,] matrix = new int[width, height];
        static int max;
       
        static void Main(string[] args)
        {
            LoadFile("matrix.txt");

            int cost = ShortestPath(0, 0);

            Console.WriteLine("Cost: " + cost);
            Console.Read();
        }

        static int Num(int x, int y)
        {
            return y * height + x;
        }

        static int ShortestPath(int x, int y)
        {
            if (values.ContainsKey(Num(x, y)))
                return values[Num(x, y)];

            if (x == width || y == height)
                return max + 1;


            int right = ShortestPath(x, y + 1);
            int down = ShortestPath(x + 1, y);

            if (x == width - 1 && y == height - 1)
            {
                int returnValue = matrix[x, y];
                values.Add(Num(x, y), returnValue);
                return returnValue;
            }

            if (x == width - 1)
            {
                int returnValue = matrix[x, y] + right;
                values.Add(Num(x, y), returnValue);
                return returnValue;
            }

            if (y == height - 1)
            {
                int returnValue = matrix[x, y] + down;
                values.Add(Num(x, y), returnValue);
                return returnValue;
            }
            
            int retValue = matrix[x, y] + (right < down ? right : down);
            values.Add(Num(x, y), retValue);
            return retValue;
        }

        static void LoadFile(string path)
        {
            StreamReader file = new StreamReader(path);
            int i = 0;
            while (!file.EndOfStream)
            {
                string[] numbers = file.ReadLine().Split(',');

                for (int j = 0; j < numbers.Length; j++)
                {
                    int newInt = int.Parse(numbers[j]);

                    max = newInt > max ? newInt : max;
                    
                    matrix[i, j] = int.Parse(numbers[j]);
                }

                i++;
            }
        }
    }
}
