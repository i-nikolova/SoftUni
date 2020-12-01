using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            const double fuelPrice = 2.10;
            const double tourPrice = 100;

            double budget = double.Parse(Console.ReadLine());
            double fuelQty = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double totalPrice = fuelQty * fuelPrice + tourPrice;

            if (day == "Saturday")
            {
                totalPrice *= 0.90;
            }
            else
            {
                totalPrice *= 0.80;
            }
            if (budget>=totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv. ");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv."
);
            }
        }
    }
}
