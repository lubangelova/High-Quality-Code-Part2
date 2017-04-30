using System;

namespace MatrixPrinter
{
    public class StartUp
    {
        public static void Main()
        {
            int n = ReadInput();
            Matrix matrix = new Matrix(n, n);
            matrix.FillMatrix();
            matrix.PrintMatrix();
        }

        public static int ReadInput()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            return n;
        }
    }
}
