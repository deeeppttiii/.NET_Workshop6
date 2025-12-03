using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public double Price { get; set; }
}

class Student
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        // -------------------------------
        // 1. Selecting / Projection
        // -------------------------------
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var squaredNumbers = numbers.Select(n => n * n).ToList();
        Console.WriteLine("Squared numbers:");
        squaredNumbers.ForEach(n => Console.WriteLine(n));

        Console.WriteLine("\n-------------------------------\n");

        // -------------------------------
        // 2. Filtering (Where)
        // -------------------------------
        List<Book> books = new List<Book>
        {
            new Book { Title = "Book A", Price = 800 },
            new Book { Title = "Book B", Price = 1200 },
            new Book { Title = "Book C", Price = 1500 },
            new Book { Title = "Book D", Price = 950 }
        };

        var premiumBooks = books.Where(b => b.Price > 1000).ToList();
        Console.WriteLine("Premium Books (Price > 1000):");
        premiumBooks.ForEach(b => Console.WriteLine($"{b.Title} - Rs. {b.Price}"));

        Console.WriteLine("\n-------------------------------\n");

        // -------------------------------
        // 3. Sorting (OrderBy)
        // -------------------------------
        List<Student> students = new List<Student>
        {
            new Student { Name = "Deepti" },
            new Student { Name = "Anish" },
            new Student { Name = "Bikash" },
            new Student { Name = "Sita" },
            new Student { Name = "Ramesh" }
        };

        var sortedStudents = students.OrderBy(s => s.Name).ToList();
        Console.WriteLine("Students sorted alphabetically:");
        sortedStudents.ForEach(s => Console.WriteLine(s.Name));

        Console.WriteLine("\n-------------------------------\n");

        // -------------------------------
        // 4. Combined Example (Chaining)
        // -------------------------------
        // Filter books priced > 1000, select only titles, sort alphabetically
        var sortedPremiumBookTitles = books
            .Where(b => b.Price > 1000)
            .Select(b => b.Title)
            .OrderBy(title => title)
            .ToList();

        Console.WriteLine("Premium Book Titles Sorted Alphabetically:");
        sortedPremiumBookTitles.ForEach(title => Console.WriteLine(title));
    }
}
