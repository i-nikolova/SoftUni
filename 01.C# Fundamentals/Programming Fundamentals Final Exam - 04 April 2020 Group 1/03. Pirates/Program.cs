using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();
            string input = string.Empty;

            while ((input=Console.ReadLine())!="Sail")
            {
                string[] cmd = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                if (!cities.ContainsKey(cmd[0]))
                {
                    cities.Add(cmd[0], new List<int>() { int.Parse(cmd[1]), int.Parse(cmd[2]) });
                }
                else
                {
                    cities[cmd[0]][0] += int.Parse(cmd[1]);
                    cities[cmd[0]][1] += int.Parse(cmd[2]);
                }

            }

            input = string.Empty;

            while ((input = Console.ReadLine())!="End")
            {
                string[] events = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string eventType = events[0];
                string town = events[1];
                

                if (eventType=="Plunder")
                {
                    int people = int.Parse(events[2]);
                    int gold = int.Parse(events[3]);
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    cities[town][0] -= people;
                    cities[town][1] -= gold;
                    if (cities[town][0] <= 0 || cities[town][1]<=0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (eventType== "Prosper")
                {
                    int gold = int.Parse(events[2]);
                    if (gold<0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }
                    cities[town][1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");

                }
            }
            if (cities.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }
}
