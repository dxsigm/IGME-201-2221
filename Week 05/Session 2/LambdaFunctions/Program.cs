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

        struct MyStruct
        {
            public int myInt;
        }

        class MyClass
        {
            public int myInt;
        }

        // note that structures are passed ***by value*** by default
        // this method will NOT change the variable that was passed to it from the parent code block
        static void MyIncrementer(MyStruct s)
        {
            ++s.myInt;
        }

        // we need the ref keyword to explicitly pass by reference
        // this method WILL change the variable that was passed from the parent code block
        static void MyIncrementer(ref MyStruct s)
        {
            ++s.myInt;
        }

        // note that classes are passed ***by reference*** by default
        static void MyIncrementer(MyClass c)
        {
            ++c.myInt;
        }

        static void MyIncrementer(Action d)
        {
            d();
        }

        static void MyAdder(Action<int, int> d)
        {
            d(1, 2);
        }

        static double Divide(int n1, byte n2)
        {
            return 0;
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
                                         (x, y) =>
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

            {
                // note that we don't need the "new" operator
                // the memory is allocated for structures because they are value data types
                MyStruct struct1;

                struct1.myInt = 42;

                // struct1 passed by value and will not be changed
                MyIncrementer(struct1);

                // struct1 passed by reference and will be changed
                MyIncrementer(ref struct1);

            }

            {
                // classes are reference data types and therefore are not allocated when defined
                MyClass class1;

                // classes need the new operator to allocate memory for them
                class1 = new MyClass();

                class1.myInt = 42;

                // class1 passed by reference and will be changed
                MyIncrementer(class1);

            }

            {
                MyClass class1 = new MyClass();

                class1.myInt = 42;

                // all of the following expressions implement the same functionality
                Func<MyClass, int> getMyIntD = delegate (MyClass m)
                {
                    return m.myInt;
                };

                Func<MyClass, int> getMyIntL1 = (MyClass m) => { return m.myInt; };  // most verbose lambda function
                Func<MyClass, int> getMyIntL2 = (m) => { return m.myInt; };
                Func<MyClass, int> getMyIntL3 = m => { return m.myInt; };
                Func<MyClass, int> getMyIntL4 = m => m.myInt;                        // least verbose lambda function

                // call one of them
                int myInt = getMyIntL1(class1);
            }

            {
                /// 1. define the delegate method data type based on the method signature
                ///         delegate double MathFunction(int n1, byte n2);
                /// 2. declare the delegate method variable
                ///         MathFunction processDivMult;
                
                // steps 1 and 2 can be replaced with the C# Action and Func delegate types
                Func<int, byte, double> processDivMult;

                // set our delegate variable to the named method, instead of using an anonymous code block
                processDivMult = Divide;

                // call the delegate
                processDivMult(12, 4);
            }

        start:
            string displayString = "";

            Random rand = new Random();

            Console.Clear();

            while (!bTimeOut)
            {
                displayString += (char)('A' + rand.Next(0, 26));

                foreach (char c in displayString)
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

                if (sAnswer.ToUpper() == displayString && !bTimeOut)
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
