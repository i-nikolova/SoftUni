using System;
using System.Threading;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedBack = Console.ReadLine();

            int daysStaying = days - 1;
            double priceRoom = 18;
            double priceApartment = 25;
            double pricePresApartment = 35;
            double fullPrice = 0;

            if (daysStaying < 10)
            {
                switch (roomType)
                {
                    case "room for one person":
                        fullPrice = (priceRoom * daysStaying);
                        break;
                    case "apartment":
                        fullPrice = ((priceApartment* daysStaying) * 0.70);
                        break;
                    case "president apartment":
                        fullPrice = ((pricePresApartment * daysStaying) * 0.90);
                        break;
                    default:
                        break;
                }
            }
            else if (daysStaying > 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        fullPrice = (priceRoom * daysStaying);
                        break;
                    case "apartment":
                        fullPrice = ((priceApartment * daysStaying) * 0.50);
                        break;
                    case "president apartment":
                        fullPrice = ((pricePresApartment * daysStaying) * 0.80);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (roomType)
                {
                    case "room for one person":
                        fullPrice = (priceRoom * daysStaying);
                        break;
                    case "apartment":
                        fullPrice = ((priceApartment * daysStaying) * 0.65);
                        break;
                    case "president apartment":
                        fullPrice = ((pricePresApartment * daysStaying) * 0.85);
                        break;
                    default:
                        break;
                }
            }
            if (feedBack == "positive")
            {
                fullPrice *= 1.25;
            }
            else
            {
                fullPrice = fullPrice*0.90;
            }
            Console.WriteLine($"{fullPrice:f2}");
        }
    }
}