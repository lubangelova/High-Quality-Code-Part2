using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CompareSimpleMath
{
    public class MathOperations
    {
        private static Stopwatch stopwatch = new Stopwatch();
        private static List<int> storeResult = new List<int>();

        public static void TestOperationsWithInt(int number, Operation operation)
        {           
            stopwatch.Start();
            for (int j = 0; j < 10; j++)
            {             
                for (int i = 1; i < 1000000; i++)
                {
                    switch (operation)
                    {
                        case Operation.Add: number += 1;
                            break;
                        case Operation.Subtract: number -= 1;
                            break;
                        case Operation.Increment: number++;
                            break;
                        case Operation.Multiply: number *= 1;
                            break;
                        case Operation.Divide: number /= 1;
                            break;
                        default: throw new InvalidOperationException("You have entered invalid operation!");
                    }                   
                }

                stopwatch.Stop();
                storeResult.Add(stopwatch.Elapsed.Milliseconds);
            }

            Console.WriteLine($"Operation {operation} with int finished for {storeResult.Average():0.00} milliseconds");          
        }

        public static void TestOperationsWithLong(long number, Operation operation)
        {
            stopwatch.Start();
            for (int j = 0; j < 10; j++)
            {
                for (int i = 1; i < 1000000; i++)
                {
                    switch (operation)
                    {
                        case Operation.Add: number += 1;
                            break;
                        case Operation.Subtract: number -= 1;
                            break;
                        case Operation.Increment: number++;
                            break;
                        case Operation.Multiply: number *= 1;
                            break;
                        case Operation.Divide: number /= 1;
                            break;
                        default: throw new InvalidOperationException("You have entered invalid operation!");
                    }
                }

                stopwatch.Stop();
                storeResult.Add(stopwatch.Elapsed.Milliseconds);
            }

            Console.WriteLine($"Operation {operation} with long finished for {storeResult.Average():0.00} milliseconds");
        }

        public static void TestOperationsWithFloat(float number, Operation operation)
        {
            stopwatch.Start();
            for (int j = 0; j < 10; j++)
            {
                for (int i = 1; i < 1000000; i++)
                {
                    switch (operation)
                    {
                        case Operation.Add: number += 1;
                            break;
                        case Operation.Subtract: number -= 1;
                            break;
                        case Operation.Increment: number++;
                            break;
                        case Operation.Multiply: number *= 1;
                            break;
                        case Operation.Divide: number /= 1;
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
                        case Operation.Add: number += 1;
                            break;
                        case Operation.Subtract: number -= 1;
                            break;
                        case Operation.Increment: number++;
                            break;
                        case Operation.Multiply: number *= 1;
                            break;
                        case Operation.Divide: number /= 1;
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
                        case Operation.Add: number += 1;
                            break;
                        case Operation.Subtract: number -= 1;
                            break;
                        case Operation.Increment: number++;
                            break;
                        case Operation.Multiply: number *= 1;
                            break;
                        case Operation.Divide: number /= 1;
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
