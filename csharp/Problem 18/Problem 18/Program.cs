using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Timer;

namespace Problem_18
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleTimer.Start();
            List<List<int>> lists = new List<List<int>>();

            StreamReader file = new StreamReader("triangle3.txt");

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] nums = line.Split(' ');

                List<int> list = new List<int>();

                foreach (string s in nums)
                {
                    list.Add(int.Parse(s));
                }
                lists.Add(list);
            }
                        
            for (int i = lists.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < lists[i].Count; j++)
                    lists[i][j] += Math.Max(lists[i + 1][j], lists[i + 1][j + 1]);
            }
            SimpleTimer.Stop();

            Console.WriteLine(SimpleTimer.ElapsedTime.Milliseconds);
            Console.WriteLine(lists[0][0]);
            Console.Read();
        }
    }
}
