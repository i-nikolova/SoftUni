using System;

namespace _04.FishingBoat
{
    class Program
    {
        static double rentBoatSpring = 3000;
        static double rentBoatWinter = 2600;
        static double rentBoatSummerAutumn = 4200;

        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberFishers = int.Parse(Console.ReadLine());
            double expences = 0;

            if (numberFishers <= 6)
            {
                switch (season)
                {
                    case "Spring":
                        expences = rentBoatSpring * 0.90;
                        break;
                    case "Summer":
                        expences = rentBoatSummerAutumn * 0.90;
                        break;
                    case "Autumn":
                        expences = rentBoatSummerAutumn * 0.90;
                        break;
                    case "Winter":
                        expences = rentBoatWinter * 0.90;
                        break;
                    default:
                        break;
                }
            }
            else if (numberFishers >= 7 && numberFishers <= 11)
            {
                switch (season)
                {
                    case "Spring":
                        expences = rentBoatSpring * 0.85;
                        break;
                    case "Summer":
                        expences = rentBoatSummerAutumn * 0.85;
                        break;
                    case "Autumn":
                        expences = rentBoatSummerAutumn * 0.85;
                        break;
                    case "Winter":
                        expences = rentBoatWinter * 0.85;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (season)
                {
                    case "Spring":
                        expences = rentBoatSpring * 0.75;
                        break;
                    case "Summer":
                        expences = rentBoatSummerAutumn * 0.75;
                        break;
                    case "Autumn":
                        expences = rentBoatSummerAutumn * 0.75;
                        break;
                    case "Winter":
                        expences = rentBoatWinter * 0.75;
                        break;
                    default:
                        break;
                }
            }
            if (numberFishers % 2 == 0 && season != "Autumn")
            {
                expences -= expences * 0.05;

            }
            if (budget >= expences)
            {
                double moneyLeft = budget - expences;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = expences - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }

        }
    }
}
