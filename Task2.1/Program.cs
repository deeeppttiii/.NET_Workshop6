using System;

namespace DiscountExample
{
    // Step 1: Define the delegate
    public delegate double DiscountStrategy(double price);

    class Program
    {
        // Step 2.1: Create CalculateFinalPrice method
        static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }

        // Step 2: Predefined discount methods
        static double FestivalDiscount(double price)
        {
            return price * 0.8; // 20% off
        }

        static double SeasonalDiscount(double price)
        {
            return price * 0.9; // 10% off
        }

        static double NoDiscount(double price)
        {
            return price; // No discount
        }

        static void Main(string[] args)
        {
            double originalPrice = 1000;

            // Step 2.2: Call CalculateFinalPrice with predefined discount methods
            double festivalPrice = CalculateFinalPrice(originalPrice, FestivalDiscount);
            Console.WriteLine($"Festival Discount Price: {festivalPrice}");

            double seasonalPrice = CalculateFinalPrice(originalPrice, SeasonalDiscount);
            Console.WriteLine($"Seasonal Discount Price: {seasonalPrice}");

            double noDiscountPrice = CalculateFinalPrice(originalPrice, NoDiscount);
            Console.WriteLine($"No Discount Price: {noDiscountPrice}");

            // Step 2.3: Call CalculateFinalPrice with a lambda expression (30% off)
            double lambdaDiscountPrice = CalculateFinalPrice(originalPrice, price => price * 0.7);
            Console.WriteLine($"Lambda 30% Discount Price: {lambdaDiscountPrice}");
        }
    }
}
