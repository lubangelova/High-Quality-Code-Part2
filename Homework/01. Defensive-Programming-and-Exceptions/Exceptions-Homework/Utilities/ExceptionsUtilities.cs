using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions_Homework.Utilities
{
    public class ExceptionsUtilities
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array can not be null!");
            }

            if (startIndex < 0 || startIndex > arr.Length)
            {
                throw new ArgumentOutOfRangeException("Start index must be between 0 and array lenght!");
            }

            if (startIndex + count > arr.Length)
            {
                throw new ArgumentOutOfRangeException("Start index + count must be less then array lenght!");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("String  can not be null or empty!");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("Count must be less then string lenght!");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static void CheckPrime(int number)
        {
            const int MinPrimeNumber = 2;
            if (number < MinPrimeNumber || number > int.MaxValue)
            {
                throw new ArgumentNullException("Number must be between 2 and 2 147 483 647!");
            }

            for (int divisor = MinPrimeNumber; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    throw new ArgumentException($"{number} is not prime!");
                }
            }
        }
    }   
}
