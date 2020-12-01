using System;

namespace _06.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double priceStat = double.Parse(Console.ReadLine());

            double priceDecor = budget * 0.10;
            if (statist > 150)
            {
                priceStat *= 0.90;
            }
            double priceClothes = statist * priceStat;
            double fullMovie = priceDecor + priceClothes;


            if (fullMovie <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - fullMovie):f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(fullMovie - budget):f2} leva more.");
            }
        }
    }
}
