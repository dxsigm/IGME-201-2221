using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                Timer timeOutTimer = new Timer(displayString.Length * 500 + 1000);

                // Timer calls the Timer.Elapsed event handler when the time elapses
                // The Timer.Elapsed event handler uses a delegate function with the following signature:
                //        public delegate void ElapsedEventHandler(object sender, ElapsedEventArgs e);
                // This delegate method type is already defined for us by .NET

                ElapsedEventHandler elapsedEventHandler = null;

                elapsedEventHandler = new ElapsedEventHandler(TimesUp);

                timeOutTimer.Elapsed += elapsedEventHandler;

                
                timeOutTimer.Elapsed += TimesUp;

                timeOutTimer.Elapsed += TimesUp2;
            }
        }

        static void TimesUp(object sender, ElapsedEventArgs e)
        {

        }

        static void TimesUp2(object sender, ElapsedEventArgs e)
        {

        }
    }
}
