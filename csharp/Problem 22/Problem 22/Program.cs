using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem_22
{
    class Program
    {
        static SortedSet<string> names = new SortedSet<string>();

        static void Main(string[] args)
        {
            GetNames("names.txt");

            int n = 1;
            int totalScore = 0;

            foreach (string s in names)
            {
                totalScore += GetNameScore(s) * n;
                n++;
            }

            Console.WriteLine("Total Name Score: " + totalScore);
        }

        static void GetNames(string filePath)
        {
            StreamReader nameFile = new StreamReader(filePath);

                string allNames = nameFile.ReadToEnd();

                string[] theNames = allNames.Split(',');

                foreach (string s in theNames)
                    names.Add(s.Replace('"',' ').Trim());
        }

        static int GetNameScore(string name)
        {
            int score = 0;
            foreach (char c in name)
            {
                
                score += (int)c - (int)'A' + 1;
            }
            return score;
        }
    }
}
