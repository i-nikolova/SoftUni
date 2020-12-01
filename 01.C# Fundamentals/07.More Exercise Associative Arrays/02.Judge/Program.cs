using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Dictionary<string, int>> participants = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> people = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] cmd = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmd[0];
                string contest = cmd[1];
                int points = int.Parse(cmd[2]);

                if (participants.ContainsKey(contest))
                {
                    if (participants[contest].ContainsKey(name))
                    {
                        if (participants[contest][name] < points)
                        {
                            participants[contest][name] = points;
                        }
                    }
                    else
                    {
                        participants[contest].Add(name, points);
                    }
                }
                else
                {
                    participants.Add(contest, new Dictionary<string, int>() { { name, points } });
                }


            }

            foreach (var contest in participants)
            {
                foreach (var person in contest.Value)
                {
                    if (people.ContainsKey(person.Key))
                    {
                        people[person.Key] += person.Value;
                    }
                    else
                    {
                        people.Add(person.Key, person.Value);
                    }
                }
            }
            foreach (var pair in participants)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count} participants");
                int countPeople = 0;
                foreach (var person in pair.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    countPeople++;
                    Console.WriteLine($"{countPeople}. {person.Key} <::> {person.Value}");
                }
            }
            Console.WriteLine("Individual standings:");
            int count = 0;
            foreach (var person in people.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                count++;
                Console.WriteLine($"{ count}. { person.Key} -> { person.Value}");
            }
        }
    }
}
