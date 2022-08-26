using System;

namespace SquashBugs
{
    // Class: Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise #1
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Prompt the user for a decimal-valued number
        //          Count down to 0 in 0.5 increments
        // Restrictions: None
        static void Main(string[] args)
        {
            bool bValid = false;

            // declare variable to hold user-entered number
            //int myNum = 0
            //int myNum = 0;   // compile-time error missing semicolon
            double myNum = 0;  // logic error should be double instead of int

            // prompt for number entry
            //Console.Write(Enter a number:);
            Console.Write("Enter a number:");  // compile-time error missing quotes

            // read user input and convert to double
            //Convert.ToDouble(Console.ReadLine());  // logic error: it will read from console and not do anything with it
            // runtime error: if user does not enter a numeric string

            while (!bValid)
            {
                try
                {
                    myNum = Convert.ToDouble(Console.ReadLine());
                    bValid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                }
            }


            // output starting value
            //Console.Write("starting value = " myNum);
            Console.Write("starting value = " + myNum);  // compile-time error: missing + operator

            // while myNum is greater than 0
            //while (myNum < 0)
            while (myNum > 0)  // logic error:  should be >
            // (  // compile time error: should be {}
            {
                // output explanation of calculation
                Console.Write("{0} - 0.5 = ", myNum);

                // output the result of the calculation
                Console.WriteLine($"{myNum - 0.5}");

                // logic error: infinite loop because myNum is not actually being decremented
                myNum -= 0.5;
                //myNum = myNum = 0.5;
            }
            //)
        }
    }
}
