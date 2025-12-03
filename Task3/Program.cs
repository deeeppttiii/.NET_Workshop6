using System;

namespace FuncExample
{
    class Program
    {
        // Method that processes numbers based on a condition
        static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (int num in numbers)
            {
                if (condition(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 7, 20, 3, 14, 8 };

            Console.WriteLine("Even numbers:");
            // Using Func delegate to filter even numbers
            ProcessNumbers(numbers, num => num % 2 == 0);

            Console.WriteLine("\nNumbers greater than 10:");
            // Using Func delegate to filter numbers greater than 10
            ProcessNumbers(numbers, num => num > 10);
        }
    }
}
