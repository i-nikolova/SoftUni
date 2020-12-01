using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();
            int numberOfDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = cmd[0];
                string name = cmd[1];
                int damage = 0;
                if (cmd[2] != "null")
                {
                    damage = int.Parse(cmd[2]);
                }
                else
                {
                    damage = 45;
                }
                int health = 0;
                if (cmd[3] != "null")
                {
                    health = int.Parse(cmd[3]);
                }
                else
                {
                    health = 250;
                }
                int armor = 0;
                if (cmd[4] != "null")
                {
                    armor = int.Parse(cmd[4]);
                }
                else
                {
                    armor = 10;
                }

                if (dragons.ContainsKey(type))
                {
                    if (dragons[type].FindIndex(x => x.Name == name) != -1)
                    {
                        int index = dragons[type].FindIndex(x => x.Name == name);
                        dragons[type][index].Armor = armor;
                        dragons[type][index].Health = health;
                        dragons[type][index].Damage = damage;
                    }
                    else
                    {
                        dragons[type].Add(new Dragon(name, damage, health, armor));
                    }
                }
                else
                {
                    dragons.Add(type, new List<Dragon>() { new Dragon(name, damage, health, armor) });
                }

            }
            
            foreach (var type in dragons)
            {
                Console.WriteLine($"{type.Key}::" +
    $"({type.Value.Average(x => x.Damage):f2}/" +
    $"{type.Value.Average(x => x.Health):f2}/" +
    $"{type.Value.Average(x => x.Armor):f2})");

                foreach (var dragon in type.Value.OrderBy(x=>x.Name))
                {
                    Console.WriteLine(dragon.ToString());
                }

            }
        }

        public class Dragon
        {
            public string Name { get; set; }
            public int Damage { get; set; }
            public int Health { get; set; }
            public int Armor { get; set; }

            public Dragon(string name, int damage, int health, int armor)
            {
                this.Name = name;
                this.Damage = damage;
                this.Health = health;
                this.Armor = armor;
            }

            public override string ToString()
            {
                return $"-{ Name} -> damage: { Damage}, health: { Health}, armor: { Armor}";
            }
        }
    }
}
