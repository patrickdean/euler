using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem_42
{
    class Program
    {
        static List<string> words = new List<string>();
        static List<int> triangleNumbers = new List<int>();
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("words.txt");
            string str = file.ReadLine();
            char[] delim = new char[3] { ',', '"', ' ' };

            int i = 1;

            do
            {
                triangleNumbers.Add(TriangleNumber(i));
                i++;
            } while (triangleNumbers.Last() < 364);

            words = new List<string>(str.Split(delim));

            Console.WriteLine(EvaluateWord("SKY".Trim()));
            int count = 0;
            foreach (string s in words)
            {
                if(s.Trim() != "")
                    count += triangleNumbers.Contains(EvaluateWord(s)) ? 1 : 0;
            }

            Console.WriteLine(count);

            Console.Read();
        }

        static int TriangleNumber(int n)
        {
            return n * (n + 1) / 2;
        }

        static int EvaluateWord(string s)
        {
            int num = 0;
            foreach (char c in s)
            {
                num += (int)(c - 'A' + 1);
            }
            return num;
        }
    }
}
