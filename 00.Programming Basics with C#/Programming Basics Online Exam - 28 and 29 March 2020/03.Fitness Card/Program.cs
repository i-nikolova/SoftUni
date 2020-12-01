using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyOwned = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string typeSport = Console.ReadLine();
            double price = 0;

            switch (sex)
            {
                case "m":
                    switch (typeSport)
                    {
                        case "Gym":
                            price = 42;
                            break;
                        case "Boxing":
                            price = 41;
                            break;
                        case "Yoga":
                            price = 45;
                            break;
                        case "Zumba":
                            price = 34;
                            break;
                        case "Dances":
                            price = 51;
                            break;
                        case "Pilates":
                            price = 39;
                            break;
                    }
                    break;
                case "f":
                    switch (typeSport)
                    {
                        case "Gym":
                            price = 35;
                            break;
                        case "Boxing":
                            price = 37;
                            break;
                        case "Yoga":
                            price = 42;
                            break;
                        case "Zumba":
                            price = 31;
                            break;
                        case "Dances":
                            price = 53;
                            break;
                        case "Pilates":
                            price = 37;
                            break;
                    }
                    break;
            }
            if (age <= 19)
            {
                price *= 0.80;
            }
            if (moneyOwned >= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {typeSport}.");
            }
            else
            {
                double moneyNeeded = price - moneyOwned;
                Console.WriteLine($"You don't have enough money! You need ${moneyNeeded:f2} more.");

            }
        }
    }
}
