using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int numProduct = 1;
            int denProduct = 1;

            for (int i = 10; i < 100; i++)
                for (int j = 10; j < 100; j++)
                {
                    if (i >= j)
                        continue;

                    if (IsCancellable(i, j))
                    {
                        numProduct *= i;
                        denProduct *= j;
                        Console.WriteLine(i + "/" + j);
                    }

                }

            Console.WriteLine(denProduct/numProduct);
            Console.ReadLine();
        }

        static bool IsCancellable(int numerator, int denominator)
        {
            if (numerator % 10 == 0 && denominator % 10 == 0)
                return false;

            string num = numerator.ToString();
            string dem = denominator.ToString();

            if (dem[0] == num[0])
            {
                if ((double)(num[1] - '0') / (double)(dem[1] - '0') == (double)numerator / (double)denominator)
                    return true;
            }
            if (dem[1] == num[1])
            {
                if ((double)(num[0] - '0') / (double)(dem[0] - '0') == (double)numerator / (double)denominator)
                    return true;
            }
            if (dem[0] == num[1])
            {
                if ((double)(num[0] - '0') / (double)(dem[1] - '0') == (double)numerator / (double)denominator)
                    return true;
            }
            if (dem[1] == num[0])
            {
                if ((double)(num[1] - '0') / (double)(dem[0] - '0') == (double)numerator / (double)denominator)
                    return true;
            }

            //foreach (char n in numerator.ToString())
            //    foreach (char d in denominator.ToString())
            //    {
            //        if ((double)(n - '0') / (double)(d - '0') == (double)numerator / (double)denominator)
            //            return true;
            //    }

            return false;
        }
    }
}
