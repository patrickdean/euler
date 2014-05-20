using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            long totalLength = 0;

            for (int i = 1; i <= 1000; i++)
            {
                num = i;
                if (num >= 1000)
                {
                    totalLength += WordLength(1) + WordLength(1000);
                    num -= 1000;
                }

                if (num >= 100)
                {
                    totalLength += WordLength(num / 100) + WordLength(100);
                    num -= (num / 100) * 100;

                    if (num > 0)
                        totalLength += "and".Length; // and
                }

                if (num >= 20)
                {
                    totalLength += WordLength(num - (num % 10));
                    totalLength += WordLength(num % 10);
                }
                else
                {
                    totalLength += WordLength(num);
                }
            }

            Console.WriteLine("Total length of words: " + totalLength);
        }


        static int WordLength(int number)
        {
            switch (number)
            {
                case 1: return "one".Length; ; // one
                case 2: return "two".Length; // two
                case 3: return "three".Length; // three
                case 4: return "four".Length; // four
                case 5: return "five".Length; // five
                case 6: return "six".Length; // six
                case 7: return "seven".Length; // seven
                case 8: return "eight".Length; // eight
                case 9: return "nine".Length; // nine
                case 10: return "ten".Length; // ten
                case 11: return "eleven".Length; // eleven
                case 12: return "twelve".Length;// twelve
                case 13: return "thirteen".Length;// thirteen
                case 14: return "fourteen".Length;// fourteen
                case 15: return "fifteen".Length;// fifteen
                case 16: return "sixteen".Length; // sixteen
                case 17: return "seventeen".Length; // seventeen
                case 18: return "eighteen".Length;// eighteen
                case 19: return "nineteen".Length;// nineteen
                case 20: return "twenty".Length;// twenty
                case 30: return "thirty".Length;// thirty
                case 40: return "forty".Length;// forty
                case 50: return "fifty".Length; // fifty
                case 60: return "sixty".Length;// sixty
                case 70: return "seventy".Length;// seventy
                case 80: return "eighty".Length;// eighty
                case 90: return "ninety".Length;// ninety
                case 100: return "hundred".Length; // hundred
                case 1000: return "thousand".Length; // thousand
            }

            return 0;
        }
    }
}
