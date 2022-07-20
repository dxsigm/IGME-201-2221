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
            // declare variable to hold user-entered number
            // int myNum = 0   syntax error missing ;
            // int myNum = 0;  syntax error because it needs to be a double to support real numbers
            double myNum = 0;

            bool bValid = false;

            // prompt for number entry
            //Console.Write(Enter a number:);  syntax error missing quotes
            Console.Write("Enter a number:");

            // read user input and convert to double
            // Convert.ToDouble(Console.ReadLine());  run-time error if the entered string is not numeric
            
            while(!bValid)
            {
                try
                {
                    // Convert.ToDouble(Console.ReadLine());  logical error not storing to myNum
                    // we also needed to change myNum from an int to a double

                    // because a double has higher precision than an int, we cannot implicitly set
                    // an int to a double
                    // you can explicitly cast a higher precision to a lower but you may lose data
                    // for example:  myInt = (int)myDouble;
                    //               myInt32 = (Int32)myInt64;

                    // there are 3 ways to convert strings to numbers
                    // 1. using the Convert class: Convert.ToDouble(), Convert.ToInt32()
                    myNum = Convert.ToDouble(Console.ReadLine());

                    // 2. using the data type's Parse method: Double.Parse(), Int32.Parse()
                    // myNum = Double.Parse(Console.ReadLine());
                    bValid = true;
                }
                catch
                {
                    Console.Write("Enter a number:");
                }
            }

            //while (!bValid)
            //{
            //    // 3. using the data type's TryParse method: Double.TryParse(), Int32.TryParse()
            //    // TryParse() returns true/false whether the string could be parsed
            //    // a cleaner solution since we don't need the try/catch blocks
            //    bValid = Double.TryParse(Console.ReadLine(), out myNum);
            //
            //    if( !bValid)
            //    {
            //        Console.Write("Enter a number:");
            //    }
            //}


            // output starting value
            // Console.Write("starting value = " myNum);  syntax error missing + for string concatenation
            // Console.Write("starting value = " + myNum); logic error should have \n
            Console.WriteLine("starting value = " + myNum);

            // while myNum is greater than 0
            //while (myNum < 0)  logical error should be >
            while (myNum > 0)
            //( syntax error
            {
                // output explanation of calculation
                Console.Write("{0} - 0.5 = ", myNum);

                // output the result of the calculation
                // Console.WriteLine($"{myNum - 0.5}"); logic error not decrementing myNum
                // we could decrement myNum in the interpolation code block
                Console.WriteLine($"{myNum = myNum - 0.5}");

                // or decrement it in a separate line of code
                //Console.WriteLine($"{myNum - 0.5}");
                //myNum = myNum - 0.5;

                // this could also be written with the decrement operator -=
                //myNum -= 0.5;
            //) syntax error
            }
        }
    }
}
