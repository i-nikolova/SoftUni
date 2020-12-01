using System;

namespace _03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string set = Console.ReadLine();
            int numberOfPacks = int.Parse(Console.ReadLine());

            if (set == "small" && fruit == "Watermelon")
            {
                double priceFruit = 56;
                double totalFruit = numberOfPacks * priceFruit;

            }


        }
    }
}
