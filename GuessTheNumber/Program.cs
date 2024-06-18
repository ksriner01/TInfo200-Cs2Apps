// Kyle Riner
// Cs2 assignment, GuessTheNumber program
// TINFO-200A, Winter 2022

//////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date         Developer   Description of change
// 02-09-2022   kriner      Creation of file, initialization of random object and number, creation of while loop, initial testing
// 02-11-2022   kriner      Documentation of program, creation of UI, final testing
//
// The GuessTheNumber program generates a random object and chooses a number between 1 and 1000 inclusive.
// The user is then prompted for a guess as to what the random number is and their guess is stored in an
// integer. While the guess number is not the target number an if statement executes to determine if the
// guess number is higher or lower than the target number. Once the user enters a guess that is equal to
// the target number, the user is congratulated and the program terminates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the namespace for the GuessTheNumber program
namespace GuessTheNumber
{
    // declaration of the class that holds the GuessTheNumber program
    internal class Program
    {
        // the main method that executes the GuessTheNumber program
        static void Main(string[] args)
        {
            Random randomNum = new Random(); // creates new random object
            int targetNum = randomNum.Next(1, 1001); // picks a number between 1 and 1000

            // user interface for GuessTheNumber program
            Console.WriteLine(@"
Welcome to the GuessTheNumber program! This program will generate a random
number between 1 and 1000 that you will proceed to attempt to guess. You will
be informed as to if your guess was too high or too low and will be prompted
for a new guess. This will continue until you guess the number correctly.
");

            // prompts the user for their initial guess and stores it in an integer guessNum
            Console.Write("Guess a number between 1 and 1000: ");
            int guessNum = int.Parse(Console.ReadLine());

            // while the user's guess is not the target number the user is given hints as
            // to whether the target number is higher or lower than their guess. the user
            // is then prompted to enter a new guess which is stored in the guessNum variable.
            // once the guessed number is the same as the target number, the program exits
            // the loop and is given a congratulations statement.
            while (guessNum != targetNum)
            {
                if (guessNum > targetNum)
                {
                    Console.WriteLine("Too high. Try again.");
                }
                else if (guessNum < targetNum)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                Console.Write("Please enter a new guess: ");
                guessNum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Congratulations, you guessed the number!");
        }
    }
}
