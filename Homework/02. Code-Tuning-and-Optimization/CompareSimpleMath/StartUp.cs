using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMath
{
    public class StartUp
    {
        public static void Main()
        {
            int intNumber = 1;
            long longNumber = 1L;
            float floatNumber = 1.0f;
            double doubleNumber = 1.0;
            decimal decimalNumber = 1m;

            MathOperations.TestOperationsWithInt(intNumber, Operation.Add);
            MathOperations.TestOperationsWithLong(longNumber, Operation.Add);
            MathOperations.TestOperationsWithFloat(floatNumber, Operation.Add);
            MathOperations.TestOperationsWithDouble(doubleNumber, Operation.Add);
            MathOperations.TestOperationsWithDecimal(decimalNumber, Operation.Add);
            PrintDashes();
            MathOperations.TestOperationsWithInt(intNumber, Operation.Subtract);
            MathOperations.TestOperationsWithLong(longNumber, Operation.Subtract);
            MathOperations.TestOperationsWithFloat(floatNumber, Operation.Subtract);
            MathOperations.TestOperationsWithDouble(doubleNumber, Operation.Subtract);
            MathOperations.TestOperationsWithDecimal(decimalNumber, Operation.Subtract);
            PrintDashes();
            MathOperations.TestOperationsWithInt(intNumber, Operation.Increment);
            MathOperations.TestOperationsWithLong(longNumber, Operation.Increment);
            MathOperations.TestOperationsWithFloat(floatNumber, Operation.Increment);
            MathOperations.TestOperationsWithDouble(doubleNumber, Operation.Increment);
            MathOperations.TestOperationsWithDecimal(decimalNumber, Operation.Increment);
            PrintDashes();
            MathOperations.TestOperationsWithInt(intNumber, Operation.Multiply);
            MathOperations.TestOperationsWithLong(longNumber, Operation.Multiply);
            MathOperations.TestOperationsWithFloat(floatNumber, Operation.Multiply);
            MathOperations.TestOperationsWithDouble(doubleNumber, Operation.Multiply);
            MathOperations.TestOperationsWithDecimal(decimalNumber, Operation.Multiply);
            PrintDashes();
            MathOperations.TestOperationsWithInt(intNumber, Operation.Divide);
            MathOperations.TestOperationsWithLong(longNumber, Operation.Divide);
            MathOperations.TestOperationsWithFloat(floatNumber, Operation.Divide);
            MathOperations.TestOperationsWithDouble(doubleNumber, Operation.Divide);
            MathOperations.TestOperationsWithDecimal(decimalNumber, Operation.Divide);
        }

        private static void PrintDashes()
        {
            Console.WriteLine(new string('-', 60));
        }
    }
}
