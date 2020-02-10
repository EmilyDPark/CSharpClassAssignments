using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06FebNoMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a date
            Console.Write("Enter a month: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a year: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // display the current date
            Console.WriteLine($"Your current date is : {m}-{d}-{y}\n");

            // Ask the user how many days they want to add
            Console.Write("Enter the number of days you'd like to add: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // calculate the new day
            int newDay = d + a;

            while (true)
            {
                Console.WriteLine($"{m}-{newDay}-{y}");

                // create an array that contains the days of the year for each month with [0] = 0
                var daysOfMonth = new[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                // In the Gregorian calendar, three criteria must be taken into account to identify leap years:
                // The year can be evenly divided by 4;
                // If the year can be evenly divided by 100, it is NOT a leap year, unless;
                // The year is also evenly divisible by 400. Then it is a leap year.
                if ((y % 4 == 0) && (y % 100 != 0) || (y % 400 == 0))
                {
                    daysOfMonth[2] = 29;
                }

                // if the new day is more than the days in the month, run again with the following month and the new day
                if (newDay > daysOfMonth[m])
                {
                    if (m != 12)
                    {
                        newDay -= daysOfMonth[m];
                        m += 1;
                        // do the while loop again with the new variables
                        continue;
                    }
                    else
                    {
                        newDay -= daysOfMonth[m];
                        m = 1;
                        y += 1;
                        // do the while loop again with the new variables
                        continue;
                    }
                }
                // if it is not more than the days in the month, print the new date
                else
                {
                    Console.WriteLine($"Your new date is: {m}-{newDay}-{y}");
                    // end the while loop
                    break;
                }
            }
        }
    }
}
