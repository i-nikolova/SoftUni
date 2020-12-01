using System;
using System.Threading;

namespace _03.NewHome
{
    class Program
    {
        static double priceRoses = 5;
        static double priceDahlias = 3.8;
        static double priceTulips = 2.8;
        static double priceNarcissus = 3;
        static double priceGladiolus = 2.5;
        static void Main(string[] args)
        {

        string flowerType = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceFlowers = 0;

            switch (flowerType)
            {
                case "Roses":
                    if (numberOfFlowers>80)
                    {
                        priceFlowers = priceRoses * numberOfFlowers;
                        priceFlowers -=priceFlowers*0.1;
                    }
                    else
                    {
                        priceFlowers = priceRoses * numberOfFlowers;
                    }
                    break;
                case "Dahlias":
                    if (numberOfFlowers > 90)
                    {
                        priceFlowers = priceDahlias * numberOfFlowers;
                        priceFlowers -= priceFlowers * 0.15;
                    }
                    else
                    {
                        priceFlowers = priceDahlias * numberOfFlowers;
                    }
                    break;
                case "Tulips":
                    if (numberOfFlowers > 80)
                    {
                        priceFlowers = priceTulips * numberOfFlowers;
                        priceFlowers -= priceFlowers * 0.15;
                    }
                    else
                    {
                        priceFlowers = priceTulips * numberOfFlowers;
                    }
                    break;
                case "Narcissus":
                    if (numberOfFlowers < 120)
                    {
                        priceFlowers = priceNarcissus * numberOfFlowers;
                        priceFlowers += priceFlowers * 0.15;
                    }
                    else
                    {
                        priceFlowers = priceNarcissus * numberOfFlowers;
                    }
                    break;
                case "Gladiolus":
                    if (numberOfFlowers < 80)
                    {
                        priceFlowers = priceGladiolus * numberOfFlowers;
                        priceFlowers += priceFlowers * 0.2;
                    }
                    else
                    {
                        priceFlowers = priceGladiolus * numberOfFlowers;
                    }
                    break;
                   default:
                    break;
            }
            if (budget>=priceFlowers)
            {
                double moneyLeft = budget - priceFlowers;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = priceFlowers - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }

        }
    }
}
