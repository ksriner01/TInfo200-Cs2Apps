// Kyle Riner
// Cs2 assignment, BarChart program
// TINFO-200A, Winter 2022

//////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date         Developer   Description of change
// 02-08-2022   kriner      Creation of file, creation of while loop and OutputStars method, initial testing
// 02-11-2022   kriner      Documentation of program, creation of UI, final testing
//
// The BarChart program prompts the user for three integers and goes through a while loop to assign
// values based on which integers were entered. A method is then called for all three of the values
// which iterates through a for loop to print out the stars for each value, creating a bar chart.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the namespace for the BarChart program
namespace BarChart
{
    // declaration of the class that holds the BarChart program
    internal class Program
    {
        // the main method that executes the code for the BarChart program
        static void Main(string[] args)
        {
            int inputCounter = 1; // counts the number of times the user has entered an input
            int bar1 = 0; // first bar in the bar chart
            int bar2 = 0; // second bar in the bar chart
            int bar3 = 0; // third bar in the bar chart

            // user interface for BarChart program
            Console.WriteLine(@"
Welcome to the BarChart program! This program will prompt you for three 
whole numbers between 1 and 30 (ex: 1, 14, 26) to construct a bar chart 
with. After entering the three numbers, the program will output three 
lines of stars that are the length of the three numbers you entered. 
This final output of stars is your bar chart of three data points.
");

            // while the user has not entered 3 values, prompts them to enter a value between 1 and 30
            // and stores the entered value in an integer. then goes through an if statment to determine 
            // how many inputs have been entered and increments one of the values accordingly. if the 
            // value is not in the range of 1 through 30 inclusive, the user is told that an appropriate
            // value wasn't entered
            while (inputCounter <= 3)
            {
                Console.Write("Please enter a value between 1 and 30: ");
                int value = int.Parse(Console.ReadLine());
                if (value >= 1 && value <= 30)
                {
                    if (inputCounter == 1)
                    {
                        bar1 += value;
                    }
                    else if (inputCounter == 2)
                    {
                        bar2 += value;
                    }
                    else if (inputCounter == 3)
                    {
                        bar3 += value;
                    }
                    inputCounter++;
                }
                else
                {
                    Console.WriteLine("An appropriate value was not entered.");
                }
            }

            OutputStars(bar1); // outputs stars for the length of the first value inputted
            OutputStars(bar2); // outputs stars for the length of the second value inputted
            OutputStars(bar3); // outputs stars for the length of the third value inputted

            // sign off at termination of program
            Console.WriteLine("\nThank you for using the BarChart program!");
        }

        // takes in an integer based on which of the three bars to output and prints out a 
        // line of stars that is the length of that number.
        public static void OutputStars(int barLength)
        {
            for (int i = 0; i < barLength; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
