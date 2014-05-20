using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1901, 1, 1);

            DateTime lastDay = new DateTime(2000, 12, 31);

            int counter = 0;

            while (date != lastDay)
            {
                if (date.Day == 1 && date.DayOfWeek == DayOfWeek.Sunday)
                    counter++;
                date = date.AddDays(1);
            }

            Console.WriteLine("Number of Sundays: " + counter);
        }
    }
}
