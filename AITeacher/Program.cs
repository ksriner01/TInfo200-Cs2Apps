// Kyle Riner
// Cs2 assignment, AITeacher program
// TINFO-200A, Winter 2022

//////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date         Developer   Description of change
// 02-10-2022   kriner      Creation of file, initialization of random object and numbers, creation of question while loop
// 02-10-2022   kriner      Initial testing of program
// 02-11-2022   kriner      Placed random numbers and question while loop into Question method, wrote yesNo while loop in main
// 02-11-2022   kriner      More testing of program after the change mentioned above
// 02-12-2022   kriner      Documentation of program, creation of UI, final testing
//
// The AITeacher program creates a random object which is used as the parameter for the Question method. The Question
// method picks two numbers from the random object and uses them as operands for a multiplication problem. So long as the
// number the student enters is not the result of the numbers multiplied by one another, the program will ask them for a
// new answer. After the first question is answered correctly, the student is prompted as to whether they would like to
// solve another problem. As long as the student enters Y for yes they will be given new questions until they enter N for
// no. If they enter anything besides these characters the will be told that they did not enter an appropriate value. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the namespace for the AITeacher program
namespace AITeacher
{
    // declaration of the class that holds the AITeacher program
    internal class Program
    {
        // the main method that executes the AITeacher program
        static void Main(string[] args)
        {
            Random randomNum = new Random(); // generates new random object

            // user interface for the AITeacher program
            Console.WriteLine(@"
Welcome to the AITeacher program! This program will help an elementary school student
learn simple multiplication. Two random single digit numbers will be generated and the
student will be asked to solve a multiplication problem of the two numbers. If they
get the problem incorrect, they will be prompted to try again until the provide the 
correct answer. Once the correct answer is given, the student will be asked if they would
like to solve another problem. So long as they answer Y for yes they will continue to 
be given new problems. If they answer N for no, the program will quit.
");

            Question(randomNum); // calls Question method at the beginning of program execution

            // after the first question is asked, the user is prompted for if they would like to continue
            // solving problems with a yes or no indication. while the input is Y for yes
            Console.Write("Would you like to solve another problem? [Y/N]: ");
            string yesNo = Console.ReadLine();

            // while the yesNo response is not null, if the yesNo response is a Y for yes the Question method is 
            // called and another yesNo prompt is given to the user upon getting the problem correct. if the 
            // yesNo response is an N for no the loop breaks and a sign off message is given to the user. if
            // the yesNo response is not a Y or N the user is informed that they did not enter an appropriate 
            // value and prompts them for a yesNo response
            while (yesNo != null)
            {
                if (yesNo == "Y")
                {
                    Question(randomNum);
                    Console.Write("Would you like to solve another problem? [Y/N]: ");
                    yesNo = Console.ReadLine();
                }
                else if (yesNo == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You did not enter an appropriate Y or N value.");
                    Console.Write("Would you like to solve another problem? [Y/N]: ");
                    yesNo = Console.ReadLine();
                }
            }

            // sign off at termination of program
            Console.WriteLine("\nThank you for using AITeacher!");
        }

        // the Question method used for gathering two random numbers and prompting the user to solve
        // a multiplication problem of the two.
        public static void Question(Random randomNum)
        {
            int firstNum = randomNum.Next(1, 10); // left operand
            int secondNum = randomNum.Next(1, 10); // right operand

            // prompts the user for the answer to the multiplication question and stores it in the
            // variable guessNum
            Console.WriteLine($"How much is {firstNum} times {secondNum}?");
            int guessNum = int.Parse(Console.ReadLine());

            // while the guessed number is not the solution to the multiplication problem, they are 
            // asked to try again and their response is stored in guessNum. when they submit the correct
            // answer to the question, they receive positive reinforcement
            while (guessNum != (firstNum * secondNum))
            {
                Console.WriteLine("No. Please try again.");
                guessNum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Very good!");

        }
    }
}