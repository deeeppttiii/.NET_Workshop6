using System;
using System.Collections.Generic;
using System.Linq;

class Booking
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public double Price { get; set; }
    public int DurationInDays { get; set; }
    public bool IsInternational { get; set; }
}

class Program
{
    static void Main()
    {
        List<Booking> bookings = new List<Booking>
        {
            new Booking { CustomerName = "Samir", Destination = "Pokhara", Price = 8000, DurationInDays = 3, IsInternational = false },
            new Booking { CustomerName = "Deepti", Destination = "Kathmandu", Price = 12000, DurationInDays = 5, IsInternational = false },
            new Booking { CustomerName = "Anish", Destination = "Paris", Price = 50000, DurationInDays = 7, IsInternational = true },
            new Booking { CustomerName = "Khushi", Destination = "London", Price = 40000, DurationInDays = 6, IsInternational = true },
            new Booking { CustomerName = "Utshab", Destination = "Chitwan", Price = 15000, DurationInDays = 5, IsInternational = false }
        };

        // LINQ query: filter, project, and sort
        var summaryReport = bookings
            .Where(b => b.Price > 10000 && b.DurationInDays > 4) // Filter
            .Select(b => new
            {
                b.CustomerName,
                b.Destination,
                Category = b.IsInternational ? "International" : "Domestic",
                b.Price
            }) // Project
            .OrderBy(b => b.Category) // Domestic first, then International
            .ThenBy(b => b.Price)    // Then sort by price
            .ToList();

        // Display the result
        Console.WriteLine("Summary Report:\n");
        foreach (var item in summaryReport)
        {
            Console.WriteLine($"Customer: {item.CustomerName}");
            Console.WriteLine($"Destination: {item.Destination}");
            Console.WriteLine($"Category: {item.Category}");
            Console.WriteLine($"Price: Rs. {item.Price}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
