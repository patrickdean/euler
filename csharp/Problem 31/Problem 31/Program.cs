using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_31
{
    class Program
    {
        static int total = 0;

        static void Main(string[] args)
        {
            List<int> coins = new List<int>() { 1, 2, 5, 10, 20, 50, 100, 200 };
        
            Change(coins, 0, 0, 200);

            Console.WriteLine(total);
            Console.Read();
        }

        static void Change(List<int> coins, int highest, int sum, int goal)
        {
            if (sum > goal)
                return;

            if (sum == goal)
            {
                total++;
                return;
            }

            foreach (int value in coins)
                if (value >= highest)
                    Change(coins, value, sum + value, goal);
        }
    }
}
