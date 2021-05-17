using Core.StoreExample;
using System;

namespace RulesDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DiscountCalculator calc = new DiscountCalculator();
            Customer cust = new Customer
            {
                DateOfBirth = new DateTime(1993, 2, 20),
                DateOfFirstPurchase = new DateTime(2021, 2, 20),
                IsVeteran = true
            };
            Console.WriteLine($"Discount for the Customer: {calc.CalculateDiscountPercentage(cust)}");
        }
    }
}
