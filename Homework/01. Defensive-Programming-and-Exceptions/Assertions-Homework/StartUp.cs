using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assertions_Homework
{
    public class StartUp
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            ArrayUtilities.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            ArrayUtilities.SelectionSort(new int[0]); // Test sorting empty array
            ArrayUtilities.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(ArrayUtilities.BinarySearch(arr, -1000));
            Console.WriteLine(ArrayUtilities.BinarySearch(arr, 0));
            Console.WriteLine(ArrayUtilities.BinarySearch(arr, 17));
            Console.WriteLine(ArrayUtilities.BinarySearch(arr, 10));
            Console.WriteLine(ArrayUtilities.BinarySearch(arr, 1000));
        }
    }
}
