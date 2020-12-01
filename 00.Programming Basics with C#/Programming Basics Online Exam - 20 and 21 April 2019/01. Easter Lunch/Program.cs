using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceCake = 3.20; 
            const double priceEgg = 4.35; 
            const double priceCookies = 5.40; 
            const double priceColor = 0.15;

            int amountCake = int.Parse(Console.ReadLine());
            int amountEggs = int.Parse(Console.ReadLine());
            int amauntCookies = int.Parse(Console.ReadLine());

            double totalCake = amountCake * priceCake;
            double totalEggs = amountEggs * priceEgg;
            double totalCookies = amauntCookies * priceCookies;
            double totalEggsColor = amountEggs * 12 * priceColor;

            double total = totalCake + totalCookies + totalEggs + totalEggsColor;

            Console.WriteLine($"{total:f2}");

        }
    }
}
