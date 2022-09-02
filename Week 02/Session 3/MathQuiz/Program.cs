using System.IO;
using System;

namespace MathQuiz
{
    // Class: Program
    // Author: David Schuh
    // Purpose: Holds the MathQuiz app
    // Restrictions: none

    // to spread a class among multiple source files, use the partial keyword
    static partial class Program
    {
        // Method: Main
        // Purpose: The MathQuiz app
        // Restrictions: None
        static void Main()
        {
            // example of calling methods which have been added via additional source files
            // call the Add2Integers() method in the other source file (CodeFile1.cs)
            int nSum = Add2Integers(1, 2);

            // store user name
            String myName = "";

            string sMyLastName;

            // string and int of # of questions
            String sQuestions = "";
            int nQuestions = 0;

            Boolean bValid = false;

            // string and base value related to difficulty
            string sDifficulty = "";
            int nMaxRange = 0;

            // constant for setting difficulty with 1 variable
            const int MAX_BASE = 10;

            ///////////////////////////////////////////////
            /// VAR IS NOT ALLOWED IN THIS COURSE /////////
            ///////////////////////////////////////////////
            var myFirstName = "david";
            ///////////////////////////////////////////////
            ///////////////////////////////////////////////
            ///////////////////////////////////////////////


            // question and # correct counters
            int nCntr = 0;
            int nCorrect = 0;

            // operator picker
            int nOp = 0;

            // operands and solution
            int val1 = 0;
            int val2 = 0;
            int nAnswer = 0;

            // string and int for the response
            string sResponse = "";
            Int32 nResponse = 0;

            // play again?
            string sAgain = "";

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            // seed the random number generator
            Random rand = new Random();

            Console.WriteLine("Math Quiz!");
            Console.WriteLine();

            // fetch the user's name into myName
            while (true)
            {
                Console.Write("What is your name-> ");
                myName = Console.ReadLine();

                if (myName.Length > 0)
                {
                    break;
                }
            }

        // label to return to if they want to play again
        start:

            // initialize correct responses for each time around
            nCorrect = 0;

            Console.WriteLine();

            // ask how many questions until they enter a valid number
            do
            {
                Console.Write("How many questions-> ");

                sQuestions = Console.ReadLine();

                bValid = int.TryParse(sQuestions, out nQuestions);
            } while (!bValid);

            Console.WriteLine();

            // ask difficulty level until they enter a valid response
            do
            {
                Console.Write("Difficulty level (easy, medium, hard)-> ");
                sDifficulty = Console.ReadLine();

            } while (sDifficulty.ToLower().Trim() != "easy" &&
                     sDifficulty.ToLower().Trim() != "medium" &&
                     sDifficulty.ToLower().Trim() != "hard");

            Console.WriteLine();

            // if they choose easy, then set nMaxRange = MAX_BASE, unless myName == "David", then set difficulty to hard
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3
            switch (sDifficulty.ToLower().Trim() )
            {
                case "easy":
                    nMaxRange = MAX_BASE;
                    if( myName.ToLower() == "david")
                    {
                        goto case "hard";
                    }
                    break;

                case "medium":
                    nMaxRange = MAX_BASE * 2;
                    break;

                case "hard":
                    nMaxRange = MAX_BASE *3;
                    break;
            }

            // ask each question
            for (nCntr = 0; nCntr < nQuestions; ++nCntr )
            {
                // generate a random number between 0 inclusive and 3 exclusive to get the operation
                nOp = rand.Next(0, 3);

                val1 = rand.Next(0, nMaxRange) + nMaxRange;
                val2 = rand.Next(0, nMaxRange);

                // if either argument is 0, pick new numbers
                if( val1 == 0 || val2 == 0 )
                {
                    --nCntr;
                    continue;
                }

                // if nOp == 0, then addition
                if( nOp == 0)
                {
                    nAnswer = val1 + val2;
                    sQuestions = $"Question #{nCntr + 1}: {val1} + {val2} => ";
                }
                // if nOp == 1, then subtraction
                else if (nOp == 1)
                {
                    nAnswer = val1 - val2;
                    sQuestions = $"Question #{nCntr + 1}: {val1} - {val2} => ";
                }
                // else multiplication
                else
                {
                    nAnswer = val1 * val2;
                    sQuestions = $"Question #{nCntr + 1}: {val1} * {val2} => ";
                }

                // bValid will be = true

                // display the question and prompt for the answer until they enter a valid number
                do
                {
                    Console.Write(sQuestions);
                    sResponse = Console.ReadLine();

                    try
                    {
                        nResponse = int.Parse(sResponse);
                        bValid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter an integer.");
                        bValid = false;
                    }
                } while (!bValid);

                // if response == answer, output flashy reward and increment # correct
                if( nResponse == nAnswer)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Well done, {0}!!!", myName);
                    ++nCorrect;
                }
                // else output stark answer
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry {0}, the answer is {1}", myName, nAnswer);
                }


                // restore the screen colors
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
            }

            Console.WriteLine();

            // output how many they got correct and their score
            Console.WriteLine("You got {0} correct out of {1}, which is a score of {2:P2}", nCorrect, nQuestions, (double)nCorrect / nCntr);

            Console.WriteLine();

            do
            {
                // prompt if they want to play again
                Console.Write("Do you want to play again? ");

                sAgain = Console.ReadLine();

                // if they type y or yes then play again
                if (sAgain.ToLower().Trim().StartsWith("y"))
                {
                    goto start;
                }
                else
                {
                    break;
                }
            } while (true);
        }
    }
}