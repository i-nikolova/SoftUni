using System;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countProducts = 0;
            double totalPrice = 0;
            double budget = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();
            
            while (product != "Stop")
            {
                double priceProduct = double.Parse(Console.ReadLine());
                countProducts++;
                if (countProducts % 3 == 0)
                {
                    priceProduct *= 0.5;
                }
                totalPrice += priceProduct;
                if (totalPrice>budget)
                {
                    double moneyNeeded = totalPrice - budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {moneyNeeded:f2} leva!");
                    break;
                }
                product = Console.ReadLine();
            }
            if (budget>=totalPrice)
            {
                Console.WriteLine($"You bought {countProducts} products for {totalPrice:f2} leva.");
            }
            
        }
    }
}
