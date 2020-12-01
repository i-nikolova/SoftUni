using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int daysStaying = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;
            double fullPriceStudio = 0;
            double fullPriceApartment = 0;


            if (daysStaying > 7 && daysStaying <= 14)
            {
                switch (month)
                {
                    case "May":
                    case "October":
                        priceStudio = 50;
                        priceApartment = 65;
                        fullPriceStudio = priceStudio * daysStaying * 0.95;
                        fullPriceApartment = priceApartment * daysStaying;
                        Console.WriteLine($"Apartment: {fullPriceApartment:f2} lv.");
                        Console.WriteLine($"Studio: {fullPriceStudio:f2} lv.");
                        break;
                    case "June":
                    case "September":
                        priceStudio = 75.20;
                        priceApartment = 68.70;
                        fullPriceStudio = priceStudio * daysStaying;
                        fullPriceApartment = priceApartment * daysStaying;
                        Console.WriteLine($"Apartment: {fullPriceApartment:f2} lv.");
                        Console.WriteLine($"Studio: {fullPriceStudio:f2} lv.");
                        break;
                    case "August":
                    case "July":
                        priceStudio = 76;
                        priceApartment = 77;
                        fullPriceStudio = priceStudio * daysStaying;
                        fullPriceApartment = priceApartment * daysStaying;
                        Console.WriteLine($"Apartment: {fullPriceApartment:f2} lv.");
                        Console.WriteLine($"Studio: {fullPriceStudio:f2} lv.");
                        break;
                    default:
                        break;
                }
            }
            else if (daysStaying > 14)
            {
                switch (month)
                {
                    case "May":
                    case "October":
                        priceStudio = 50;
                        priceApartment = 65;
                        fullPriceStudio = priceStudio * daysStaying * 0.70;
                        fullPriceApartment = priceApartment * daysStaying * 0.90;
                        Console.WriteLine($"Apartment: {fullPriceApartment:f2} lv.");
                        Console.WriteLine($"Studio: {fullPriceStudio:f2} lv.");
                        break;
                    case "June":
                    case "September":
                        priceStudio = 75.20;
                        priceApartment = 68.70;
                        fullPriceStudio = priceStudio * daysStaying * 0.80;
                        fullPriceApartment = priceApartment * daysStaying * 0.90;
                        Console.WriteLine($"Apartment: {fullPriceApartment:f2} lv.");
                        Console.WriteLine($"Studio: {fullPriceStudio:f2} lv.");
                        break;
                    case "August":
                    case "July":
                        priceStudio = 76;
                        priceApartment = 77;
                        fullPriceStudio = priceStudio * daysStaying;
                        fullPriceApartment = priceApartment * daysStaying * 0.90;
                        Console.WriteLine($"Apartment: {fullPriceApartment:f2} lv.");
                        Console.WriteLine($"Studio: {fullPriceStudio:f2} lv.");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (month)
                {
                    case "May":
                    case "October":
                        priceStudio = 50;
                        priceApartment = 65;
                        fullPriceStudio = priceStudio * daysStaying;
                        fullPriceApartment = priceApartment * daysStaying;
                        Console.WriteLine($"Apartment: {fullPriceApartment:f2} lv.");
                        Console.WriteLine($"Studio: {fullPriceStudio:f2} lv.");
                        break;
                    case "June":
                    case "September":
                        priceStudio = 75.20;
                        priceApartment = 68.70;
                        fullPriceStudio = priceStudio * daysStaying;
                        fullPriceApartment = priceApartment * daysStaying;
                        Console.WriteLine($"Apartment: {fullPriceApartment:f2} lv.");
                        Console.WriteLine($"Studio: {fullPriceStudio:f2} lv.");
                        break;
                    case "August":
                    case "July":
                        priceStudio = 76;
                        priceApartment = 77;
                        fullPriceStudio = priceStudio * daysStaying;
                        fullPriceApartment = priceApartment * daysStaying;
                        Console.WriteLine($"Apartment: {fullPriceApartment:f2} lv.");
                        Console.WriteLine($"Studio: {fullPriceStudio:f2} lv.");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
