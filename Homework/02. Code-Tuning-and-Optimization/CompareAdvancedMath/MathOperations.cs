using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareAdvancedMath
{
    public class MathOperations
    {
        private static Stopwatch stopwatch = new Stopwatch();
        private static List<int> storeResult = new List<int>();
        private static double result = 0;

        public static void TestOperationsWithFloat(float number, Operation operation)
        {           
            stopwatch.Start();
            for (int j = 0; j < 10; j++)
            {
                for (int i = 1; i < 1000000; i++)
                {
                    switch (operation)
                    {
                        case Operation.SquareRoot:
                            result = Math.Sqrt(number);
                            break;
                        case Operation.Log:
                            result = Math.Log(number);
                            break;
                        case Operation.Sin:
                            result = Math.Sin(number);
                            break;
                        default: throw new InvalidOperationException("You have entered invalid operation!");
                    }
                }

                stopwatch.Stop();
                storeResult.Add(stopwatch.Elapsed.Milliseconds);
            }

            Console.WriteLine($"Operation {operation} with float finished for {storeResult.Average():0.00} milliseconds");
        }

        public static void TestOperationsWithDouble(double number, Operation operation)
        {
            stopwatch.Start();
            for (int j = 0; j < 10; j++)
            {
                for (int i = 1; i < 1000000; i++)
                {
                    switch (operation)
                    {
                        case Operation.SquareRoot:
                            result = Math.Sqrt(number);
                            break;
                        case Operation.Log:
                            result = Math.Log(number);
                            break;
                        case Operation.Sin:
                            result = Math.Sin(number);
                            break;
                        default: throw new InvalidOperationException("You have entered invalid operation!");
                    }
                }

                stopwatch.Stop();
                storeResult.Add(stopwatch.Elapsed.Milliseconds);
            }

            Console.WriteLine($"Operation {operation} with double finished for {storeResult.Average():0.00} milliseconds");
        }

        public static void TestOperationsWithDecimal(decimal number, Operation operation)
        {
            stopwatch.Start();
            for (int j = 0; j < 10; j++)
            {
                for (int i = 1; i < 1000000; i++)
                {
                    switch (operation)
                    {
                        case Operation.SquareRoot:
                            result = Math.Sqrt((double)number);
                            break;
                        case Operation.Log:
                            result = Math.Log((double)number);
                            break;
                        case Operation.Sin:
                            result = Math.Sin((double)number);
                            break;
                        default: throw new InvalidOperationException("You have entered invalid operation!");
                    }
                }

                stopwatch.Stop();
                storeResult.Add(stopwatch.Elapsed.Milliseconds);
            }

            Console.WriteLine($"Operation {operation} with decimal finished for {storeResult.Average():0.00} milliseconds");
        }
    }
}
