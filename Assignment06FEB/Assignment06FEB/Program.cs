using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06FEB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a date
            Console.Write("Enter a month: ");
            int userMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day: ");
            int userDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a year: ");
            int userYear = Convert.ToInt32(Console.ReadLine());

            // display the current date
            string userDate = userMonth + "-" + userDay + "-" + userYear;
            Console.WriteLine($"Your current date is : {userDate}\n");

            // Ask the user how many days they want to add
            Console.Write("Enter the number of days you'd like to add: ");
            int userAdd = Convert.ToInt32(Console.ReadLine()); v
            Console.WriteLine();

            // run the AddDaysToDate method
            AddDaysToDate(userMonth, userDay, userYear, userAdd);


            // test inputs
            //AddDaysToDate(2, 6, 2020, 5); // 2-11-2020
            //AddDaysToDate(2, 6, 2020, 9); // 2-15-2020
            //AddDaysToDate(2, 6, 2020, 18); // 2-24-2020
            //AddDaysToDate(2, 6, 2020, 23); // 2-29-2020
            //AddDaysToDate(2, 6, 2020, 24); // 3-1-2020
            //AddDaysToDate(2, 6, 2020, 72); // 4-18-2020
            //AddDaysToDate(2, 6, 2020, 200); // 8-24-2020
            //AddDaysToDate(2, 6, 2020, 1000); // 11-2-2022
            //AddDaysToDate(2, 6, 2020, 10000); // 6-24-2047
        }

        // create a method to check if it is a leap year
        static bool IsLeapYear(int y)
        {
            // In the Gregorian calendar, three criteria must be taken into account to identify leap years:
            // The year can be evenly divided by 4;
            // If the year can be evenly divided by 100, it is NOT a leap year, unless;
            // The year is also evenly divisible by 400. Then it is a leap year.

            if ((y % 4 == 0) || ((y % 4 == 0) && (y % 400 == 0)))
            {
                return true;
            }
            else if (y % 100 != 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        static void AddDaysToDate(int m, int d, int y, int a)
        {
            //Console.WriteLine($"{m}-{d}-{y}");

            // create an array that contains the days of the year for each month
            var daysOfMonth = new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // if year is a leap year, make February have 29 days
            if (IsLeapYear(y))
            {
                daysOfMonth[1] = 29;
            }

            // calculate the new day
            int newDay = d + a;

            // if the new day is more than the days in the month, run again with the following month and the new day
            if (newDay > daysOfMonth[m - 1])
            {
                if (m != 12)
                {
                    m += 1;
                    d = newDay - daysOfMonth[m-2];
                    AddDaysToDate(m, d, y, 0);
                }
                else
                {
                    d = newDay - daysOfMonth[m - 1];
                    y += 1;
                    AddDaysToDate(1, d, y, 0);
                }
            }
            // if it is not more than the days in the month, print the new date
            else
            {
                Console.WriteLine($"Your new date is: {m}-{newDay}-{y}");
            }
        }
    }
}
