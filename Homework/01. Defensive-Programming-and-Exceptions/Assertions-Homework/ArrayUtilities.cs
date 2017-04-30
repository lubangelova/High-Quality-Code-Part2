using System;
using System.Diagnostics;

public class ArrayUtilities
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array can not be null!");
        Debug.Assert(arr.Length > 0, "Array can not be empty!");

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array can not be null!");
        Debug.Assert(arr.Length > 0, "Array can not be empty!");
        Debug.Assert(value != null, "Value can not be null!");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
      where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array can not be null!");
        Debug.Assert(arr.Length > 0, "Array can not be empty!");
        Debug.Assert(value != null, "Value can not be null!");
        Debug.Assert(startIndex >= 0 && startIndex <= arr.Length - 1, "Start index must be between 0 and array lenght!");
        Debug.Assert(endIndex >= 0 && endIndex <= arr.Length - 1, "End index must be between 0 and array lenght!");
        Debug.Assert(startIndex <= endIndex, "Start index must be less or equal end index!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array can not be null!");
        Debug.Assert(arr.Length > 0, "Array can not be empty!");
        Debug.Assert(startIndex >= 0 && startIndex <= arr.Length - 1, "Start index must be between 0 and array lenght!");
        Debug.Assert(endIndex >= 0 && endIndex <= arr.Length - 1, "End index must be between 0 and array lenght!");
        Debug.Assert(startIndex <= endIndex, "Start index must be less or equal end index!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x != null && y != null, "Values to swap can not be null!");
        
        T oldX = x;
        x = y;
        y = oldX;
    }  
}
