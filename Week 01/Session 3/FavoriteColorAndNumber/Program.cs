// the using statement gives us access to objects, methods and enums in a namespace without having to prefix them every time
// for example, without line #3, we would have to type System.Console.ReadLine() every time
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// we can define other namespaces at the same level as the app's namespace
namespace ColorNameSpace
{
    // we can nest namespaces within each other
    // a namespace to hold the user's favorite color
    namespace Color
    {
        // Class: ColorClass
        // Author: David Schuh
        // Purpose: Class to contain the user's favorite color
        // Restrictions: None
        // BE SURE TO ADD THE "static" KEYWORD TO ALL CLASS DEFINITIONS DURING UNIT 1!
        static public class ColorClass
        {
            public static string sFavColor;
        }
    }
}

namespace FavoriteColorAndNumber
{
    // we can define a namespace alias for more concise access
    // we only have to type CAlias.ColorClass.sFavColor instead of ColorNameSpace.Color.ColorClass.sFavColor
    using CAlias = ColorNameSpace.Color;

    // a namespace to hold the user's favorite number
    namespace Number
    {
        // Class: NumberClass
        // Author: David Schuh
        // Purpose: Class to contain the user's favorite number
        // Restrictions: None
        // BE SURE TO ADD THE "static" KEYWORD TO ALL CLASS DEFINITIONS DURING UNIT 1!
        static public class NumberClass
        {
            public static int? nFavNumber;
        }
    }


    // Class: Program
    // Author: David Schuh
    // Purpose: Console Read/Write and Exception-handling exercise
    // Restrictions: None
    // BE SURE TO ADD THE "static" KEYWORD TO ALL CLASS DEFINITIONS DURING UNIT 1!
    static internal class Program
    {
        // Method: PrintMyColor
        // Purpose: Demonstrate passing variables "by value"
        // Restrictions: None
        // without the "ref" keyword, the variable is passed according to the default behavior
        // the primitive data types all behave as "by value" variables by default
        static void PrintMyColor(string sColorString)
        {
            // sColorString is a local string variable to this method
            // which will receive a copy of the passed variable from the calling method
            // append " is your favorite color" to sColorString, which will not change the variable in the calling method
            // note that a += b is the same as a = a + b
            sColorString += " is your favorite color";
            Console.WriteLine(sColorString);
        }

        // Method: PrintMyColorByReference
        // Purpose: Demonstrate passing variables "by reference"
        // Restrictions: None
        // adding the "ref" keyword, the variable is passed "by reference" and the local
        // method variable sColorString will be a pointer or reference to the passed variable in the calling method
        static void PrintMyColorByReference(ref string sColorString)
        {
            // sColorString is a local string variable to this method
            // but it is a reference to the passed variable from the calling method
            // which means any changes to sColorString will change the variable in the calling method
            // append " is your favorite color" to sColorString, which WILL change the variable in the calling method
            // note that a += b is the same as a = a + b
            sColorString += " is your favorite color";
            Console.WriteLine(sColorString);
        }


        // Method: Main
        // Purpose: Prompt the user for their favorite color and number
        //          Output their favorite color (in limited text colors) their favorite number of times
        // Restrictions: None
        static void Main(string[] args)
        {
            // refer to Week #1 Lecture Notes for the summary of all of the primitive data types
            // the primitive data types are "value" data types in that they are referenced by value, and have their data stored in discrete "boxes" (or chunks of memory)
            // the string data type is also a value pointer in that it can be set to null, which indicates it is not pointing to any valid data
            string sFavColor = null;

            // note that variables cannot start with a number, but can contain numbers
            // the only special character variables can contain is the underscore "_"
            // they can start with underscore
            // Best practice is to use camelcase for variable names, which means the variable starts lowercase and each subsequent word is capitalized
            // I prefer using the first character to indicate the variable data type.  For example:
            //      "s" : string  (sFavColor)
            //      "n  : numeric (nFavNumber)
            //      "b" : bool (bValid)


            // this line will cause a runtime exception because sFavColor is a null pointer and does not point to valid data
            // trying to uppercase a null pointer will cause a runtime exception
            //sFavColor = sFavColor.ToUpper();

            // this line sets sFavColor to an empty or null string
            // note that the string is pointing to valid data, and that data is a null character, which can be represented with the special character \0
            // the statement could be written more explicitly sFavColor = "\0";
            sFavColor = "";

            // we can try to uppercase any characters that the string points to
            // but note that because string is a primitive data type, passing the string to a method, like ToUpper(), passes it "by value" and does not change the string itself
            // it returns the uppercase of the string, but we are not saving that returned value anywhere
            // effectively this statement is the equivalent of calling ToUpper(sFavColor)
            // the string class has a ToUpper() method which acts upon itself
            sFavColor.ToUpper();

            // if we want to uppercase the string, then we need to set itself to the uppercase of itself
            sFavColor = sFavColor.ToUpper();

            // the other primitive data types are not pointer values by default and therefore cannot be set to null
            // the following statement, if uncommented, will cause a compile-time error
            // int nFavNumber = null;

            // we can override the data type support the null pointer by adding the "?" suffix to the primitive data type
            int nFavNumber = 0;
            

            // code blocks define the scope of variables
            {
                int n = 5;

                //int nFavNumber = 0.5;

                n = nFavNumber;

            }

            int n = 3;

            //n = 2;

            // comments can be created with double slash
            // or slash star ... star slash
            /// or 3 slashes
            /* this is also a comment*/

            // prompt the user for their favorite color
            // \t is the escape sequence for the tab character
            // note that System. is not necessary since we have the "using" statement at the top of the code
            System.Console.Write("Enter your favorite color:\t");

            // get the user's input and store it in a variable
            // the following statement reads a line from the Console, but does not store it anywhere
            //Console.ReadLine();

            // we need a variable and the equal operator to copy the Console input to our variable
            sFavColor = Console.ReadLine();

            PrintMyColor(sFavColor);
            PrintMyColorByReference(ref sFavColor);

            // we can set our ColorNameSpace object to the string as well using the alias
            CAlias.ColorClass.sFavColor = sFavColor;

            // prompt the user for their favorite number
            //Console.Write("Enter your favorite number:\t");

            // validate that the user entered a valid number
            // we want a loop until the user enters a valid number
            // note that Console.ReadLine() can only read strings, and if the user does not enter a number, then a runtime error will occur
            // you must write code that validates all user input and does not crash!
            
            string sNumber = "";
            do
            {
                Console.Write("Enter your favorite number:\t");
                sNumber = Console.ReadLine());
            } while (!int.TryParse(sNumber, out nFavNumber));

            //double.TryParse()

            // the do...while() loop always executes the loop at least once
            // and checks the while condition after the first execution
            do
            {
                // Convert.ToInt32() will generate a runtime error (exception) if the passed in string is not a valid number
                // therefore, we "try" to convert it
                try
                {
                    // get the user's input and store it in a variable
                    nFavNumber = Convert.ToInt32(System.Console.ReadLine());

                    // store the favorite number in the favorite number namespace
                    Number.NumberClass.nFavNumber = nFavNumber;
                }
                // and "catch" any exception that occurs
                catch
                {
                    // by asking the user to enter an integer
                    Console.WriteLine("Please enter an integer");
                }

                // and we put this in a loop while nFavNumber is null
                // the advantage of initializing nFavNumber to a null pointer is that we know whether they entered a valid number or not
                // if we initialize it to 0 or 123456, those may be someone's favorite number, so we wouldn't know that they entered those numbers!
            } while (nFavNumber == null);

            // the while() loop may never execute if the condition is false, since the condition is tested before entering the loop
            //while(nFavNumber != null)
            //{
            //    try
            //    {
            //        // get the user's input and store it in a variable
            //        nFavNumber = Convert.ToInt32(System.Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Please enter an integer");
            //    }
            //}


            // change the output text color to match their favorite color
            // we can switch based on a standard capitalization, such as lowercase
            // note that this DOES NOT change the capitalization of the string stored in sFavColor
            switch (sFavColor.ToLower())
            {
                // we only need to test for each lowercase color
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                // if none of the above cases are met, then we want the default to execute
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
            }

            // the switch statement is similar to an if... then... else if... then... else
            // note how much more work is involved to do the same code as the string needs to be lowercased everytime
            // double equals is used to test for equality in C#
            if (sFavColor.ToLower() == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (sFavColor.ToLower() == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (sFavColor.ToLower() == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }


            // output their favorite color the number of times as their favorite number
            // use a for(initialization;condition;operation) loop to output their favorite color the number of times as their favorite number
            // The three statements within the for() statement:
            //      1. initialization statement(s):  (i = 0) any variable initialization
            //          Note that this can include multiple comma-separated statements.
            //              For example:   for( i=0, y=0, color=Console.ReadLine(); i < favNum; ++i)
            //
            //      2. condition check:  (i < favNum) what to check at the beginning of the loop each time it loops (including the first time)
            //
            //      3. operation: (++i)  any operations to execute upon each subsequent start of the loop (not including the first time)
            //          Note that this can include multiple comma-separated statements.
            //              For example:   for( i=0, y=0, color=Console.ReadLine(); i < favNum; ++i, ++y)
            //
            //          Note that using the "continue" statement to return to the top of the loop will execute the operation statement(s)
            //          so that if you need to do something N times, you may have to --i before the "continue" to repeat the same value of i.
            //

            for (int i = 0; i < nFavNumber; i += 1)
            {
                // different ways to generate output
                // appending strings using the "+" operator
                Console.WriteLine("Your favorite color is " + sFavColor + "! (appending)");

                // embedding code blocks using string interpolation
                Console.WriteLine($"Your favorite color is {sFavColor + "!"} (interpolation)");

                // substituting numbered tokens with comma-separated arguments
                Console.WriteLine("Your favorite color is {0}{1} (substitution)", sFavColor, "!");
            }

            // three kinds of coding errors:
            // 1. compile-time (syntax) errors: the code will not even compile
            // 2. run-time errors or exceptions: the code compiles and runs, but encounters an exception that crashes the app (eg. trying to access a null pointer, divide by zero, etc)
            // 3. logic errors: the code compiles and runs but does the wrong thing!

            // for example a logic error would be to write the above for() loop incorrectly as:
            // for (int i = 1; i < nFavNumber; i += 1)
            // starting from 1 to nFavNumber will output 1 less than desired.
            // if starting from 1, then the test needs to be: i <= nFavNumber

            // explaining the incrementer operator (++)
            int x = 0;
            int y = 0;

            // with the incrementer prefix, x is incremented when the statement first executes
            y = ++x;  // y = 1   x = 1

            x = 0;
            y = 0;

            // with the incrementer postfix, x is incremented at the end of statement execution
            y = x++;  // y = 0  x = 1
        }
    }
}