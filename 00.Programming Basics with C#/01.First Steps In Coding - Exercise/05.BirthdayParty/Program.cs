using System;

namespace _05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceHall = double.Parse(Console.ReadLine());
            double priceCake = priceHall * 0.20;
            double priceDrinks = priceCake - (priceCake * 0.45);
            double priceAnimator = priceHall / 3;

            double fullPrice = priceHall + priceCake + priceDrinks + priceAnimator;

            Console.WriteLine($"{fullPrice:f2}");

        }
    }
}
