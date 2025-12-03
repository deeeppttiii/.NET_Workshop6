using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create rectangle object
            Rectangle rect = new Rectangle();

            // Assign values
            rect.Length = 10.5;
            rect.Breadth = 5.2;

            // Display details
            Console.WriteLine(rect.ShowDetails());

            // Calculate and display area
            Console.WriteLine($"Area: {rect.GetArea()}");

            // Calculate and display perimeter
            Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");

            Console.ReadLine(); // Wait for user to close console
        }
    }
}
