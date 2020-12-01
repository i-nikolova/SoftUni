using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                heroes.Add(info[0], new List<int>() { int.Parse(info[1]), int.Parse(info[2]) });
            }

            string input = string.Empty;

            while ((input=Console.ReadLine())!="End")
            {
                string[] cmdArgs = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string heroName = cmdArgs[1];

                switch (command)
                {
                    case "CastSpell":
                        int mpNeeded = int.Parse(cmdArgs[2]);
                        string spellName = cmdArgs[3];
                        if (mpNeeded<=heroes[heroName][1])
                        {
                            heroes[heroName][1]=heroes[heroName][1] - mpNeeded;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(cmdArgs[2]);
                        string attacker = cmdArgs[3];
                        if (damage< heroes[heroName][0])
                        {
                            heroes[heroName][0] = heroes[heroName][0] - damage;
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                        }
                        else
                        {
                            heroes.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        break;
                    case "Recharge":
                        int amount = int.Parse(cmdArgs[2]);
                        if (heroes[heroName][1]+amount>200)
                        {
                            amount = 200 - heroes[heroName][1];
                            heroes[heroName][1] = 200;
                        }
                        else
                        {
                            heroes[heroName][1] = heroes[heroName][1] + amount;
                        }
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        break;
                    case "Heal":
                        int heal = int.Parse(cmdArgs[2]);
                        if (heroes[heroName][0] + heal > 100)
                        {
                            heal = 100 - heroes[heroName][0];
                            heroes[heroName][0] = 100;
                        }
                        else
                        {
                            heroes[heroName][0] = heroes[heroName][0] + heal;
                        }
                        Console.WriteLine($"{heroName} healed for {heal} HP!");
                        break;
                    default:
                        break;
                }
            }
            foreach (var hero in heroes.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"HP: {hero.Value[0]}");
                Console.WriteLine($"MP: {hero.Value[1]}");
            }
        }
    }
}
