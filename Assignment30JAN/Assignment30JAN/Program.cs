using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment30JAN
{
    class Program
    {
        static void Main(string[] args)
        {
            #region User Input

            // Ask the user for their height
            Console.WriteLine("What is your height in inches?");

            // Assign the user's input to a string variable and create a double variable
            string stringHeight = (Console.ReadLine());
            double height = 0;

            // Make sure that the user input a numerical value with a try/catch block
            try
            {
                // Try to convert user's input to a double
                height = Convert.ToDouble(stringHeight);
            }
            catch (FormatException)
            {
                // If the user did not input a number, print this
                Console.WriteLine("Input must be a numerical value. Please try again.");
                // Exit the program
                System.Environment.Exit(5);
            }


            // Ask the user for their weight
            Console.WriteLine("What is your weight in pounds?");

            // Assign the user's input to a string variable and create a double variable
            string stringWeight = (Console.ReadLine());
            double weight = 0;

            // Make sure that the user input a numerical value with a try/catch block
            try
            {
                // Try to convert user's input to a double
                weight = Convert.ToDouble(stringWeight);
            }
            catch (FormatException)
            {
                // If the user did not input a number, print this
                Console.WriteLine("Input must be a numberical value. Please try again.");
                // Exit the program
                System.Environment.Exit(5);
            }


            // Use the method with the user's height and weight
            FindClassification(height, weight);

            #endregion

            #region Test Values

            ////Test with these sample height and weight values
            //FindClassification(70, 15);
            //FindClassification(70, 115);
            //FindClassification(70, 120);
            //FindClassification(70, 150);
            //FindClassification(70, 175);
            //FindClassification(70, 210);
            //FindClassification(70, 245);
            //FindClassification(70, 289);

            #endregion


            // See method below
            // I chose to complete this assignment the way that I did in order to show on the console
            // what the input data was as well as the classification output.

        }

        static void FindClassification(double h, double w)
        {
            // Use the user's height and weight information to calculate BMI
            // Round the number to 2 digits after decimal
            double BMI = Math.Round(((w * 703) / (h * h)), 2);

            // Using an if statement with several else if clauses to determine the user's classification
            if (BMI < 16)
            {
                Console.WriteLine($"\nHeight: {h} \nWeight:{w} \nBMI:{BMI} \nClassification: Underweight (Severe thinness)\n");
            }
            else if (BMI < 17)
            {
                Console.WriteLine($"\nHeight: {h} \nWeight:{w} \nBMI:{BMI} \nClassification: Underweight (Moderate thinness)\n");
            }
            else if (BMI < 17.5)
            {
                Console.WriteLine($"\nHeight: {h} \nWeight:{w} \nBMI:{BMI} \nClassification: Underweight (Mild thinness)\n");
            }
            else if (BMI < 25)
            {
                Console.WriteLine($"\nHeight: {h} \nWeight:{w} \nBMI:{BMI} \nClassification: Normal weight\n");
            }
            else if (BMI < 30)
            {
                Console.WriteLine($"\nHeight: {h} \nWeight:{w} \nBMI:{BMI} \nClassification: Overweight\n");
            }
            else if (BMI < 35)
            {
                Console.WriteLine($"\nHeight: {h} \nWeight:{w} \nBMI:{BMI} \nClassification: Obese (Obese class I)\n");
            }
            else if (BMI < 40)
            {
                Console.WriteLine($"\nHeight: {h} \nWeight:{w} \nBMI:{BMI} \nClassification: Obese (Obese class II)\n");
            }
            else
            {
                Console.WriteLine($"\nHeight: {h} \nWeight:{w} \nBMI:{BMI} \nClassification: Obese (Obese class III)\n");
            }
        }
    }
}
