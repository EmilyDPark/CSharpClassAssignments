using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test to make sure that my leap year logic is correct
            
            int count = 0;

            for (int y = 1730; y < 2004; y++)
            {
                if (y % 400 == 0)
                {
                    Console.WriteLine(y);
                    count += 1;
                }
                else if ((y % 4 == 0) && (y % 100 != 0))
                {
                    Console.WriteLine(y);
                    count +=1;
                }
            }

            Console.WriteLine(count);
        }
    }
}
