using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guest = int.Parse(Console.ReadLine());
            double priceForGuest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            double cakePrice = budget * 0.10;

            if (guest >=10 && guest <=15)
            {
                totalPrice = guest * priceForGuest * 0.85;
            }
            else if (guest >15 && guest<=20)
            {
                totalPrice = guest * priceForGuest * 0.80;

            }
            else if (guest > 20)
            {
                totalPrice = guest * priceForGuest * 0.75;

            }
            else
            {
                totalPrice = guest * priceForGuest;

            }

            double totalPriceParty = totalPrice + cakePrice;
            if (totalPriceParty>budget)
            {
                double moneyNeeded = totalPriceParty - budget;
                Console.WriteLine($"No party! {moneyNeeded:f2} leva needed.");
            }
            else
            {
                double moneyLeft = budget - totalPriceParty;
                Console.WriteLine($"It is party time! {moneyLeft:f2} leva left.");
            }



        }
    }
}
