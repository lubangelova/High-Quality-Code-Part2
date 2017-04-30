using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareAdvancedMath
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            float floatNumber = 1.0f;
            double doubleNumber = 1.0;
            decimal decimalNumber = 1m;

            MathOperations.TestOperationsWithFloat(floatNumber, Operation.SquareRoot);
            MathOperations.TestOperationsWithDouble(doubleNumber, Operation.SquareRoot);
            MathOperations.TestOperationsWithDecimal(decimalNumber, Operation.SquareRoot);
            PrintDashes();
            MathOperations.TestOperationsWithFloat(floatNumber, Operation.Log);
            MathOperations.TestOperationsWithDouble(doubleNumber, Operation.Log);
            MathOperations.TestOperationsWithDecimal(decimalNumber, Operation.Log);
            PrintDashes();
            MathOperations.TestOperationsWithFloat(floatNumber, Operation.Sin);
            MathOperations.TestOperationsWithDouble(doubleNumber, Operation.Sin);
            MathOperations.TestOperationsWithDecimal(decimalNumber, Operation.Sin);
        }

        private static void PrintDashes()
        {
            Console.WriteLine(new string('-', 60));
        }
    }
}
