using System;
using System.Collections.Generic;
using System.Linq;

// Classes for each scenario
class CashierSales
{
    public string Name { get; set; }
    public double Sales { get; set; }
}

class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Music
{
    public string Title { get; set; }
    public int DurationSeconds { get; set; } // Duration in seconds
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Aggregation Operators ===\n");

        // Aggregation Example
        List<CashierSales> salesData = new List<CashierSales>
        {
            new CashierSales { Name = "Cashier A", Sales = 1500 },
            new CashierSales { Name = "Cashier B", Sales = 2200 },
            new CashierSales { Name = "Cashier C", Sales = 1800 },
            new CashierSales { Name = "Cashier D", Sales = 2500 }
        };

        int totalCashiers = salesData.Count();
        double totalSales = salesData.Sum(c => c.Sales);
        double highest = salesData.Max(c => c.Sales);
        double lowest = salesData.Min(c => c.Sales);
        double average = salesData.Average(c => c.Sales);

        Console.WriteLine($"Total Cashiers: {totalCashiers}");
        Console.WriteLine($"Total Sales: Rs. {totalSales}");
        Console.WriteLine($"Highest Sale: Rs. {highest}");
        Console.WriteLine($"Lowest Sale: Rs. {lowest}");
        Console.WriteLine($"Average Sale: Rs. {average:F2}");

        Console.WriteLine("\n=== Quantifier Operators ===\n");

        // Quantifier Example
        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant { Name = "Ram", Age = 17 },
            new Applicant { Name = "Sita", Age = 20 },
            new Applicant { Name = "Hari", Age = 16 },
            new Applicant { Name = "Gita", Age = 18 }
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine($"Any applicant under 18? {anyUnder18}");
        Console.WriteLine($"All applicants above 16? {allAbove16}");

        Console.WriteLine("\n=== Element Operators ===\n");

        // Element Example
        List<Music> songs = new List<Music>
        {
            new Music { Title = "Song A", DurationSeconds = 180 },
            new Music { Title = "Song B", DurationSeconds = 240 },
            new Music { Title = "Song C", DurationSeconds = 300 },
            new Music { Title = "Song D", DurationSeconds = 600 }
        };

        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstAbove4Min = songs.First(s => s.DurationSeconds > 240);
        var firstAbove10Min = songs.FirstOrDefault(s => s.DurationSeconds > 600);

        Console.WriteLine($"First Song: {firstSong.Title}");
        Console.WriteLine($"Last Song: {lastSong.Title}");
        Console.WriteLine($"First song longer than 4 minutes: {firstAbove4Min.Title}");
        Console.WriteLine(firstAbove10Min != null
            ? $"First song longer than 10 minutes: {firstAbove10Min.Title}"
            : "No song longer than 10 minutes found.");
    }
}
