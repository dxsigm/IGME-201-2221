using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string sNumber = null;
            int nNumber = 0;
            int nAnswer = 0;

            do
            {
                Console.Write("Enter a positive integer: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nNumber) && nNumber <= 0);

            // non-recursive
            //nAnswer = 1;
            //
            //while( nNumber > 0)
            //{
            //    nAnswer *= nNumber;
            //    --nNumber;
            //}

            Factorial(nNumber);

            Console.Write($"{sNumber + "!"} = {nAnswer}");
        }

        static int Factorial(int v)
        {
            int returnVal = 0;


            // base case: 0! = 1
            if( v == 0)
            {
                returnVal = 1;
            }
            else
            {
                returnVal = v * Factorial(v - 1);
            }

            return returnVal;
        }

        //Factorial(2): 2 * Factorial(1) : waiting at line 47
        //Factorial(1): 1 * Factorial(0) : waiting at line 47
        //Factorial(0): return 1
        //
        //Factorial(1): 1 * 1 : return 1
        //Factorial(2): 2 * 1 : return 2
    }
}
