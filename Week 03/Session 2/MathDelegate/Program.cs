using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// delegate steps
/// 1. define the delegate method data type based on the method signature
///         delegate double MathFunction(double n1, double n2);
/// 2. declare the delegate method variable
///         MathFunction processDivMult;
/// 3. point the variable to the method that it should call
///         processDivMult = new MathFunction(Multiply);
/// 4. call the delegate method
///         nAnswer = processDivMult(n1, n2);

namespace MathDelegate
{
    // this defines a delegate DATA TYPE called MathFunction
    // which needs to have the same signature as the methods that its variables will reference
    delegate double MathFunction(double n1, double n2);

    static internal class Program
    {
        // delegate method data type can be declared within namespace or within a class
        //delegate double MathFunction(double n1, double n2);

        static void Main(string[] args)
        {
            string sNumber = null;
            string sOperation = null;

            double nNum1 = 0;
            double nNum2 = 0;
            double nAnswer = 0;

            // prompt and convert first number
            do
            {
                Console.Write("Enter a number: ");
                sNumber = Console.ReadLine();
            } while (!double.TryParse(sNumber, out nNum1));

            // prompt and convert second number
            do
            {
                Console.Write("Enter another number: ");
                sNumber = Console.ReadLine();
            } while (!double.TryParse(sNumber, out nNum2));

            // prompt for operation
            do
            {
                Console.Write("Multiply or Divide: ");
                sOperation = Console.ReadLine();
            } while (!sOperation.ToLower().StartsWith("m") &&
                     !sOperation.ToLower().StartsWith("d"));

            MathFunction processDivMult;

            if( sOperation.ToLower().StartsWith("m"))
            {
                //nAnswer = Multiply(nNum1, nNum2);
                processDivMult = new MathFunction(Multiply);
                processDivMult = Multiply;
            }
            else
            {
                //nAnswer = Divide(nNum1, nNum2);
                processDivMult = new MathFunction(Divide);
                processDivMult = Divide;

            }

            nAnswer = processDivMult(nNum1, nNum2);

        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
