using System;
using System.Data.SqlTypes;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string typeKart = Console.ReadLine();
            string fanCard = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            double priceTicket = 0;

            switch (typeKart)
            {
                case "five":
                    switch (typeTicket)
                    {
                        case "Child":
                            priceTicket = 7;
                            break;
                        case "Junior":
                            priceTicket = 9;
                            break;
                        case "Adult":
                            priceTicket = 12;
                            break;
                        case "Profi":
                            priceTicket = 18;
                            break;
                        default:
                            break;
                    }
                    break;
                        case "ten":
                    switch (typeTicket)
                    {
                        case "Child":
                            priceTicket = 11;
                            break;
                        case "Junior":
                            priceTicket = 16;
                            break;
                        case "Adult":
                            priceTicket = 21;
                            break;
                        case "Profi":
                            priceTicket = 32;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            if (fanCard=="yes")
            {
                priceTicket *= 0.80;
            }
            if (priceTicket>budget)
            {
                double moneyNeeded = priceTicket - budget;
                Console.WriteLine($"You don't have enough money! You need {moneyNeeded:f2}lv more.");
            }
            else
            {
                double moneyLeft = budget - priceTicket;
                Console.WriteLine($"You bought {typeTicket} ticket for {typeKart} laps. Your change is { moneyLeft:f2}lv.");
            }


        }
    }
}
