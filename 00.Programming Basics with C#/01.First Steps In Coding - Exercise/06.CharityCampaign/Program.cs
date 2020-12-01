using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double cakePrice = 45.00;
            double waffelsPrice = 5.80;
            double pancakePrice = 3.20;

            int campainDays = int.Parse(Console.ReadLine());
            int numberCookers = int.Parse(Console.ReadLine());
            int numberCakes = int.Parse(Console.ReadLine());
            int numberWaffels = int.Parse(Console.ReadLine());
            int numberPancakes = int.Parse(Console.ReadLine());

            double priceForCake = cakePrice * numberCakes;
            double priceForWaffels = waffelsPrice * numberWaffels;
            double priceForPancakes = pancakePrice * numberPancakes;

            double priceForADay = campainDays * (priceForCake + priceForPancakes + priceForWaffels);
            double priceForCampain = priceForADay * numberCookers;
            double finalPrice = priceForCampain - (priceForCampain / 8);

            Console.WriteLine($"{finalPrice:f2}");


        }
    }
}
