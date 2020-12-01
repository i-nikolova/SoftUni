using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace _04.SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

            while ((input=Console.ReadLine())!="Once upon a time")
            {
                string[] cmd = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmd[0];
                string color = cmd[1];
                int points = int.Parse(cmd[2]);

                if (dwarfs.ContainsKey(color))
                {
                    if (dwarfs[color].ContainsKey(name))
                    {
                        if (dwarfs[color][name]<points)
                        {
                            dwarfs[color][name] = points;
                        } 
                    }
                    else
                    {
                        dwarfs[color].Add(name, points);
                    }
                }
                else
                {
                    dwarfs.Add(color, new Dictionary<string, int>() { { name, points } });
                }
            }

            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();
            foreach (var hatColor in dwarfs.OrderByDescending(x => x.Value.Count()))
            {
                foreach (var dwarf in hatColor.Value)
                {
                    sortedDwarfs.Add($"({hatColor.Key}) {dwarf.Key} <-> ", dwarf.Value);
                }
            }
            foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }
        }
    }
}
