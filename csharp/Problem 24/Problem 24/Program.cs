using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_24
{
    class Program
    {
        static List<int> original;
        static List<long> permutations;

        static void Main(string[] args)
        {
            ResetOriginalList();
            permutations = new List<long>();

            CreatePermutations(original, 0);
            original.Add(original[0]);
            original.RemoveAt(0);

            permutations.Sort();
            Console.WriteLine(permutations[999999]);
            Console.Read();
        }
        
        static void CreatePermutations(List<int> digits, long number)
        {
            List<int> newDigits = new List<int>(digits);

            if (digits.Count == 1)
            {
                number *= 10;
                number += digits[0];
                permutations.Add(number);
            }
            foreach (int i in digits)
            {
                newDigits.Remove(i);
                long num = 10 * number + i;
                CreatePermutations(newDigits, num);
                newDigits.Add(i);
            }
        }
        
        static void ResetOriginalList()
        {
            original = new List<int>();

            for (int i = 0; i < 10; i++)
                original.Add(i);
        }

    }
}
