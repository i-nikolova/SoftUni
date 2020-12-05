using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                if (plants.Any(x => x.Name == plantInfo[0]))
                {
                    plants[plants.FindIndex(x => x.Name == plantInfo[0])].Rarity = int.Parse(plantInfo[1]);
                }
                else
                {
                    Plant plantAdd = new Plant(plantInfo[0], int.Parse(plantInfo[1]), new List<double>());
                    plants.Add(plantAdd);
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArgs = input.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                string plant = cmdArgs[1];

                switch (command)
                {
                    case "Rate":
                        if (plants.FindIndex(x => x.Name == plant) != -1)
                        {
                            double rating = double.Parse(cmdArgs[2]);
                            plants[plants.FindIndex(x => x.Name == plant)].Rating.Add(rating);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Update":
                        if (plants.FindIndex(x => x.Name == plant) != -1)
                        {
                            int rarity = int.Parse(cmdArgs[2]);
                            plants[plants.FindIndex(x => x.Name == plant)].Rarity = rarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Reset":
                        if (plants.FindIndex(x => x.Name == plant) != -1)
                        {
                            plants[plants.FindIndex(x => x.Name == plant)].Rating.RemoveRange(0,
                                plants[plants.FindIndex(x => x.Name == plant)].Rating.Count);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in plants.OrderByDescending(x => x.Rarity)
                .ThenByDescending(x => x.Rating.Count > 0 ? x.Rating.Average() : 0.00))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class Plant
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<double> Rating { get; set; } = new List<double>();
        public Plant(string name, int rarity, List<double> ratings)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.Rating = ratings;
        }

        public override string ToString()
        {
            double rating = Rating.Count > 0 ? Rating.Average() : 0.00;
            return $"{Name}; Rarity: {Rarity}; Rating: {rating:f2} ";
        }
    }
}
