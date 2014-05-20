using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_76
{
    class Program
    {
        static int total = 0;

        static void Main(string[] args)
        {
            int max = 100;
            List<int> coins = new List<int>();

            for (int i = 1; i < max; i++)
                coins.Add(i);

            Change(coins, 0, 0, max);

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
