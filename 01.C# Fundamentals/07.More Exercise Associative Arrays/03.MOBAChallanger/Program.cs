using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace _03.MOBAChallanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] cmd = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string name = cmd[0];
                    string skill = cmd[1];
                    int points = int.Parse(cmd[2]);

                    if (people.ContainsKey(name))
                    {
                        if (people[name].ContainsKey(skill))
                        {
                            if (people[name][skill] < points)
                            {
                                people[name][skill] = points;
                            }
                        }
                        else
                        {
                            people[name].Add(skill, points);
                        }
                    }
                    else
                    {
                        people.Add(name, new Dictionary<string, int>() { { skill, points } });
                    }
                }
                else
                {
                    string[] cmd = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string playerOne = cmd[0];
                    string playerTwo = cmd[1];
                    string playerToRemove = string.Empty;
                    bool isBattle = false;
                    if (people.ContainsKey(playerOne) && people.ContainsKey(playerTwo))
                    {
                        foreach (var skill in people[playerOne])
                        {
                            foreach (var power in people[playerTwo])
                            {
                                if (skill.Key == power.Key)
                                {
                                    isBattle = true;
                                    if (skill.Value < power.Value)
                                    {
                                       playerToRemove= playerOne;
                                        break;
                                    }
                                    else if (power.Value < skill.Value)
                                    {
                                        playerToRemove=playerTwo;
                                        break;
                                    }
                                }
                            }
                        }
                        if (isBattle)
                        {
                            people.Remove(playerToRemove);
                        }
                        
                    }
                }

            }


       
            foreach (var person in people.OrderByDescending(x=>x.Value.Sum(x=>x.Value)).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{person.Key}: {person.Value.Sum(x => x.Value)} skill");
                foreach (var skill in person.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {skill.Key} <::> {skill.Value}");
                }
            }
        }
    }
}
