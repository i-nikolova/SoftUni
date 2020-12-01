using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForDogs = 2.50;
            double priceForOthers = 4.00;
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOthers = int.Parse(Console.ReadLine());
            double finalPrice = (numberOfDogs * priceForDogs) + (numberOfOthers * priceForOthers);
            Console.WriteLine($"{finalPrice} lv");

        }
    }
}
