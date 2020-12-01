using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = new Dictionary<string, int>();

            string[] inputRacers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var racer in inputRacers)
            {
                if (!racers.ContainsKey(racer))
                {
                    racers.Add(racer, 0);
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine())!="end of race")
            {
                string name = string.Empty;
                int distance = 0;
                Regex regex = new Regex(@"[A-Za-z0-9]");
                if (regex.IsMatch(input))
                {
                    foreach (Match item in regex.Matches(input))
                    {
                        if (char.IsDigit(char.Parse(item.Value)))
                        {
                            distance += int.Parse(item.Value);
                        }
                        else
                        {
                            name += item.Value;
                        }
                    }
                }

                if (racers.ContainsKey(name))
                {
                    racers[name] += distance;
                }
            }

            int possion = 0;
            foreach (var racer in racers.OrderByDescending(x=>x.Value).Take(3))
            {
                possion++;
                if (possion==1)
                {
                    Console.WriteLine($"1st place: {racer.Key}");
                }
                else if (possion==2)
                {
                    Console.WriteLine($"2nd place: {racer.Key}");
                }
                else
                {
                    Console.WriteLine($"3rd place: {racer.Key}");
                }
            }
            
        }
    }
}
