using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contest = new Dictionary<string, string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] line = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                contest.Add(line[0], line[1]);
            }

            input = string.Empty;
            Dictionary<string, List<Contests>> participanst = new Dictionary<string, List<Contests>>();
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] cmd = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                if (contest.ContainsKey(cmd[0]))
                {
                    if (contest[cmd[0]] == cmd[1])
                    {
                        if (participanst.ContainsKey(cmd[2]))
                        {
                            if (participanst[cmd[2]].FindIndex(x => x.Name == cmd[0]) != -1)
                            {
                                if ((participanst[cmd[2]][participanst[cmd[2]].FindIndex(x => x.Name == cmd[0])].Points) < int.Parse(cmd[3]))
                                {
                                    participanst[cmd[2]][participanst[cmd[2]].FindIndex(x => x.Name == cmd[0])].Points = int.Parse(cmd[3]);

                                }

                            }
                            else
                            {
                                participanst[cmd[2]].Add(new Contests(cmd[0], int.Parse(cmd[3])));
                            }
                        }
                        else
                        {
                            participanst.Add(cmd[2], new List<Contests>() { new Contests(cmd[0], int.Parse(cmd[3])) });
                        }
                    }
                }
            }
            int bestPoints = int.MinValue;
            string winned = string.Empty;
            foreach (var pair in participanst)
            {
                int sumPoints = 0;
                foreach (var item in pair.Value)
                {
                    sumPoints += item.Points;
                }
                if (sumPoints>bestPoints)
                {
                    bestPoints = sumPoints;
                    winned = pair.Key;
                }
            }
            Console.WriteLine($"Best candidate is {winned} with total {bestPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var pair in participanst.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{pair.Key}");
                foreach (var item in pair.Value.OrderByDescending(x=>x.Points))
                {
                    Console.WriteLine($"#  {item.Name} -> {item.Points}");
                }
            }

        }
        public class Contests
        {
            public string Name { get; set; }
            public int Points { get; set; }

            public Contests(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }
        }

    }
}
