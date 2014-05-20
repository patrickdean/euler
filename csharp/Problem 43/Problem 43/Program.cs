using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_43
{
    class Program
    {
        static string pandigitalString = "0123456789";
        static List<int> primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17 };
        static List<string> permutations = new List<string>();

        static void Main(string[] args)
        {
            long sum = 0;
            CreatePermutations(pandigitalString, "");

            foreach (string s in permutations)
                if (CheckDivisibility(s))
                    sum += long.Parse(s);
            
            Console.WriteLine(sum);
            Console.Read();
        }

        static bool CheckDivisibility(string number)
        {
            for (int i = 1; i < 8; i++)
            {
                int num = int.Parse(number.Substring(i, 3));

                if (num % primes[i-1] != 0)
                    return false;
            }
            
            return true;
        }

        static bool IsPandigital(string number)
        {
            foreach (char c in pandigitalString)
            {
                if (!number.Contains(c))
                    return false;
            }

            return true;
        }

        static void CreatePermutations(string digits, string number)
        {
            string newDigits = String.Copy(digits);

            if (digits.Length == 1)
            {
                number += digits[0];
                permutations.Add(number);
            }
            foreach (char c in digits)
            {
                if (c == '0' && digits.Length == 10)
                    continue;

                newDigits = newDigits.Remove(newDigits.IndexOf(c), 1);
                string num = String.Copy(number) + c;
                CreatePermutations(newDigits, num);
                newDigits += c;
            }
        }
    }
}
