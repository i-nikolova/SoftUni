using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double moneySpend = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                switch (season)
                {
                    case "summer":
                    moneySpend = Math.Round(budget * 0.30,2);
                        Console.WriteLine($"Camp - {moneySpend:f2}");
                        break;
                    case "winter":
                        moneySpend = Math.Round(budget * 0.70,2);
                        Console.WriteLine($"Hotel - {moneySpend:f2}");
                        break;
                    default:
                        break;
                }
            }
            else if (budget > 100 && budget <=1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                switch (season)
                {
                    case "summer":
                        moneySpend = Math.Round(budget * 0.40,2);
                        Console.WriteLine($"Camp - {moneySpend:f2}");
                        break;
                    case "winter":
                        moneySpend = Math.Round(budget * 0.80,2);
                        Console.WriteLine($"Hotel - {moneySpend:f2}");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                moneySpend = Math.Round(budget * 0.90,2);
                Console.WriteLine($"Hotel - {moneySpend:f2}");
                    
                }
            }

        }
    }

