using System;

namespace Task1
{
    public delegate int Calculate(int a, int b);
    public delegate double DiscountStrategy(double price);

    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Part 1: Add & Subtract using delegate ---
            Calculate calcAdd = Add;
            Calculate calcSub = Subtract;

            Console.WriteLine("Addition: " + calcAdd(10, 5));
            Console.WriteLine("Subtraction: " + calcSub(10, 5));

            // --- Part 2: Discounts using delegate ---
            DiscountStrategy discount;

            discount = FestivalDiscount;
            Console.WriteLine("Festival Discount: " + discount(1000));

            discount = SeasonalDiscount;
            Console.WriteLine("Seasonal Discount: " + discount(1000));

            discount = NoDiscount;
            Console.WriteLine("No Discount: " + discount(1000));

            Console.ReadLine();
        }

        // Methods for Calculate delegate
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;

        // Methods for DiscountStrategy delegate
        public static double FestivalDiscount(double price) => price * 0.80;
        public static double SeasonalDiscount(double price) => price * 0.90;
        public static double NoDiscount(double price) => price;
    }
}
