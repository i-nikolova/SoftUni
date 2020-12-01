using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool isWinned = false;
            while (!isWinned)
            {
                List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower()).ToList();

                for (int i = 0; i < input.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        if (input[i] == "shards" || input[i] == "fragments" || input[i] == "motes")
                        {
                            keyMaterials[input[i]] += int.Parse(input[i - 1]);
                            if (keyMaterials[input[i]] >= 250)
                            {
                                switch (input[i])
                                {
                                    case "shards":
                                        Console.WriteLine("Shadowmourne obtained!");
                                        keyMaterials["shards"] -= 250;
                                        break;
                                    case "fragments":
                                        Console.WriteLine("Valanyr obtained!");
                                        keyMaterials["fragments"] -= 250;
                                        break;
                                    case "motes":
                                        Console.WriteLine("Dragonwrath obtained!");
                                        keyMaterials["motes"] -= 250;
                                        break;
                                    default:
                                        break;
                                }
                                isWinned = true;
                                break;

                            }
                        }
                        else
                        {
                            if (junk.ContainsKey(input[i]))
                            {
                                junk[input[i]] += int.Parse(input[i - 1]);
                            }
                            else
                            {
                                junk.Add(input[i], int.Parse(input[i - 1]));
                            }
                        }
                    }
                }
            }

            keyMaterials = keyMaterials.OrderByDescending(m => m.Value).ThenBy(m => m.Key).ToDictionary(x => x.Key, x => x.Value);
            junk = junk.OrderBy(m => m.Key).ToDictionary(d => d.Key, d => d.Value);
            foreach (var pair in keyMaterials)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            foreach (var pair in junk)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

        }
    }
}
