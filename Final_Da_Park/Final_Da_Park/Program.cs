using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Da_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            // ============================== Problem 1 ==============================
            Console.WriteLine("Problem 1: \n");
            Problem1("Da Hye (Emily) Park");


            // ============================== Problem 2 ==============================
            Console.WriteLine("\n\n\nProblem 2: \n");
            Problem2("Emily", "Park");


            // ============================== Problem 3 ==============================
            Console.WriteLine("\n\n\nProblem 3: \n");
            Problem3();

            Console.WriteLine("\nTest Cases");
            Problem3("0,1,2,3,4,5,6,7,8,9");
            Problem3("0,8,2,3,7,5,6,4,1,9");
            Problem3("0,1,2,3,5,4,6,7,8,9");
            Problem3("9,8,7,6,5,4,3,2,1,0");


            // ============================== Problem 4 ==============================
            Console.WriteLine("\n\n\nProblem 4: \n");
            Console.WriteLine(HighLow("1 2 3 4 5"));
            Console.WriteLine(HighLow("1 2 -3 4 5"));
            Console.WriteLine(HighLow("1 9 3 4 -5"));
            Console.WriteLine(HighLow("13"));

        } // Main method


        public static void Problem1(string name)
        {
            // In this function you need to print your name three times using for loop, then print your name again three times using While loop.

            Console.WriteLine("For Loop");
            for (int i = 0; i < 3; i++) // This for loop creates a variable i and sets it to 0. For as long as i < 3, it will execute the code. After it executes the code, it will increment i by 1
            {
                Console.WriteLine(name); // Print the string given as the method's parameter
            }

            Console.WriteLine("\nWhile Loop");
            int j = 0; // Create a variable j and set it to 0
            while (j < 3) // This while loop will execute the code for as long as j < 3
            {
                Console.WriteLine(name); // Print the string given as the method's parameter
                j++; // Increment j by 1
            }

        } // Problem1 method


        public static void Problem2(string firstName, string lastName)
        {
            // In this function you need to create an array. 
            // The first index of the array should have your first name and the second index of the array should have your last name. 
            // Use for loop to print your lastName then your firstName.

            var nameArr = new string[2]; // Create a string array of size 2 because the method only has 2 parameters

            nameArr[0] = firstName; // Set the value of the first index of nameArr as the firstName given as a parameter
            nameArr[1] = lastName; // Set the value of the second index of nameArr as the lastName given as a parameter

            for (int i = 1; i >= 0; i--) // Use a for loop to print lastName then firstName
            {
                Console.WriteLine(nameArr[i]);
            }

        } // Problem2 method


        public static void Problem3()
        {
            // Create a program to ASK the user for 10 integer numbers (from -1000 to 1000), sort them and display them sorted.
            // (Note you can't use sort or similar function to solve the problem, You need to write your own code)

            Console.WriteLine("Please enter 10 numbers (from -1000 to 1000) separated by commas");
            var nums = Console.ReadLine();

            var numArr = new int[10]; // Create an array of size 10

            var index = 0; // Create a variable to use as an index counter
            foreach (string num in nums.Split(',')) // Split the string with the ','
            {
                numArr[index] = (Convert.ToInt32(num)); // Convert each num to an int and add to the array
                index++; // Increment the index counter by 1
            }

            // Sort the int array
            var temp = 0; // Create a variable to be used as a temp
            for (int i = 0; i < 10; i++) // First for loop to get the number to compare
            {
                for (int j = i + 1; j < 10; j++) // Second for loop to get the number to compare with
                {
                    if (numArr[i] > numArr[j]) // Check if the first number is larger than the second number
                    {
                        // Swap the two numbers
                        temp = numArr[i];
                        numArr[i] = numArr[j];
                        numArr[j] = temp;
                    }
                }
            }

            Console.WriteLine($"Sorted Numbers: {String.Join(",", numArr)}"); // Display the sorted array

        } // Problem3 method

        public static void Problem3(string nums) // Just to make testing easier
        {
            var numArr = new int[10];

            var index = 0;
            foreach (string num in nums.Split(','))
            {
                numArr[index] = (Convert.ToInt32(num));
                index++;
            }

            var temp = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (numArr[i] > numArr[j])
                    {
                        temp = numArr[i];
                        numArr[i] = numArr[j];
                        numArr[j] = temp;
                    }
                }
            }

            Console.WriteLine($"Sorted Numbers: {String.Join(",", numArr)}"); // Display the sorted array

        } // Problem3 method with 1 parameter


        public static string HighLow(string input)
        {
            // Create a function that accepts a string of space separated numbers and returns the highest and lowest number (as a string). 

            var max = Convert.ToInt32(input.Split(' ').First()); // Set max as the first number in the input split at ' ' converted to an int
            var min = Convert.ToInt32(input.Split(' ').First()); // Set min as the first number in the input split at ' ' converted to an int

            foreach (string num in input.Split(' ')) // Use a foreach loop to pull each num string from the input split at ' '
            {
                if (Convert.ToInt32(num) > max) // Check if the converted num is larger than the current max
                {
                    max = Convert.ToInt32(num); // Set max to num
                }
                else if (Convert.ToInt32(num) < min) // Check if the converted num is smaller than the current min
                {
                    min = Convert.ToInt32(num); // Set min to num
                }
            }

            return $"{max.ToString()} {min.ToString()}"; // Return the max number and min number as a string separated by a space

        } // HighLow method

    } // Program class

} // Final_Da_Park namespace
