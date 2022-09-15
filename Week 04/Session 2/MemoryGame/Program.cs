using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;


/// delegate steps
/// 1. define the delegate method data type based on the method signature
///         delegate double MathFunction(double n1, double n2);
/// 2. declare the delegate method variable
///         MathFunction processDivMult;
/// 3. point the variable to the method that it should call
///         processDivMult = new MathFunction(Multiply);
/// 4. call the delegate method / add the delegate method to the object's event handler
///         nAnswer = processDivMult(n1, n2);
///         timer.Elapsed += TimesUp;

namespace MemoryGame
{
    static internal class Program
    {
        // if we need to access variables from within multiple methods below,
        // we can declare them in the parent code block of the class
        // be sure to use the "static" keyword, since we are not creating any objects yet!
        static bool bTimeOut = false;

        static Timer timeOutTimer;

        static void MyIncrementer(Action d)
        {
            d();
        }

        static void MyAdder(Action<int, int> d)
        {
            d(1, 2);
        }

        static void Main(string[] args)
        {
            {
                int i = 0;
                int j = 0;

                Action increment = //delegate ()
                                   () =>
                    { 
                        ++i;
                        ++j;
                    };

                Action<int, int> adder = //delegate (int x, int y)
                                         //(int x, int y) =>
                                         (x,y) =>
                    {
                        i += x;
                        j += y;
                    };

                Func<int> fnIncrement = //delegate ()
                                   () =>
                                   {
                                       ++i;
                                       ++j;
                                       return (i + j);
                                   };

                Func<int, int, int> fnAdder = //delegate (int x, int y)
                                         //(int x, int y) =>
                                         (x, y) =>
                                         {
                                             i += x;
                                             j += y;
                                             return (i + j);
                                         };

                increment();

                MyIncrementer(increment);

                MyAdder(adder);

            }

        start:
            string displayString = "";

            Random rand = new Random();

            Console.Clear();

            while(!bTimeOut)
            {
                displayString += (char)('A' + rand.Next(0, 26));

                foreach(char c in displayString)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(500);
                }

                Console.Clear();

                timeOutTimer = new Timer(displayString.Length * 500 + 1000);

                // Timer calls the Timer.Elapsed event handler when the time elapses
                // The Timer.Elapsed event handler uses a delegate function with the following signature:
                //        public delegate void ElapsedEventHandler(object sender, ElapsedEventArgs e);
                // This delegate method type is already defined for us by .NET

                ElapsedEventHandler elapsedEventHandler = null;

                elapsedEventHandler = new ElapsedEventHandler(TimesUp);

                timeOutTimer.Elapsed += elapsedEventHandler;
                timeOutTimer.Elapsed += TimesUp;

                elapsedEventHandler = new ElapsedEventHandler(TimesUp2);

                timeOutTimer.Elapsed += elapsedEventHandler;

                // add another method to be called by the Elapsed event handler
                timeOutTimer.Elapsed += TimesUp2;

                // remove a method from being called
                timeOutTimer.Elapsed -= TimesUp2;

                // 5 ways to add the delegate method
                timeOutTimer.Elapsed += elapsedEventHandler;  // adding a named method via a delegate variable
                timeOutTimer.Elapsed += TimesUp;              // add a method directly
                timeOutTimer.Elapsed += delegate (object sender, ElapsedEventArgs e) // add an anonymous method
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your time is up!");
                        bTimeOut = true;
                        timeOutTimer.Stop();
                    };

                timeOutTimer.Elapsed += (object sender, ElapsedEventArgs e) => // add a lambda function ( "=>" is the lambda operator)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your time is up!");
                        bTimeOut = true;
                        timeOutTimer.Stop();
                    };

                timeOutTimer.Elapsed += (sender, e) => // simplified lambda function ( "=>" is the lambda operator)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Your time is up!");
                    bTimeOut = true;
                    timeOutTimer.Stop();
                };


                string sAnswer = null;
                sAnswer = Console.ReadLine();

                timeOutTimer.Stop();

                if( sAnswer.ToUpper() ==  displayString && !bTimeOut)
                {
                    Console.WriteLine("Well Done!  Your current score is {0}", displayString.Length);
                }
                else
                {
                    Console.WriteLine("Bad luck.  :(  The correct code was {0}.  Your final score is: {1}", displayString, displayString.Length - 1);

                    bTimeOut = true;
                }
            }

            Console.Write("Press Enter to Play Again");
            Console.ReadLine();

            goto start;
        }

        static void TimesUp(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("");
            Console.WriteLine("Your time is up!");
            bTimeOut = true;
            timeOutTimer.Stop();
        }

        static void TimesUp2(object sender, ElapsedEventArgs e)
        {

        }
    }
}
