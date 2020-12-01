using System;

namespace _02._Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceCake = 4.0;
            const double priceEggs = 0.45;

            int guest = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double numberOfCake = Math.Ceiling((guest*1.0 / 3));
            int numberOfEggs = guest * 2;

            double totalCake = numberOfCake * priceCake;
            double totalEggs = numberOfEggs * priceEggs;

            double total = totalCake + totalEggs;

            if (total>budget)
            {
                double moneyNeeded = total - budget;
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {moneyNeeded:f2} lv. more.");
            }
            else
            {
                double moneyLeft = budget - total;
                Console.WriteLine($"Lyubo bought {numberOfCake} Easter bread and {numberOfEggs} eggs.");
                Console.WriteLine($"He has {moneyLeft:f2} lv. left.");
            }


        }
    }
}
