using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their height
            Console.WriteLine("What is your height in inches?");
            // Convert the string resonse to a double value
            double height = Convert.ToDouble(Console.ReadLine());

            // Ask the user for their weight
            Console.WriteLine("What is your weight in pounds?");
            // Convert the string response to a double value
            double weight = Convert.ToDouble(Console.ReadLine());

            // Use the user's height and weight information to calculate BMI
            double BMI = (weight * 703) / (height * height);

            // I tested the if statement by commenting out the above code and inputing example BMI results.
            //double BMI;
            //BMI = 15;
            //BMI = 16.5;
            //BMI = 24.9;
            //BMI = 37.5;
            //BMI = 40;
            //BMI = 45;

            // Using an if statement with several else if clauses to determine the user's classification
            if (BMI < 16)
            {
                Console.WriteLine("Your classification is: Underweight (Severe thinness)");
            }
            else if (BMI < 17)
            {
                Console.WriteLine("Your classification is: Underweight (Moderate thinness)");
            }
            else if (BMI < 17.5)
            {
                Console.WriteLine("Your classification is: Underweight (Mild thinness)");
            }
            else if (BMI < 25)
            {
                Console.WriteLine("Your classification is: Normal weight");
            }
            else if (BMI < 30)
            {
                Console.WriteLine("Your classification is: Overweight");
            }
            else if (BMI < 35)
            {
                Console.WriteLine("Your classification is: Obese (Obese class I)");
            }
            else if (BMI < 40)
            {
                Console.WriteLine("Your classification is: Obese (Obese class II)");
            }
            else
            {
                Console.WriteLine("Your classification is: Obese (Obese class III)");
            }

            // I chose this method because it is very clear where the next classification begins. If a BMI does 
            // not fit in one if/else if statement, it wil move on to the next one until it applies.
        }
    }
}
