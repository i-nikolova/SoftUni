using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dragons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<Dragons> dragonsList = new List<Dragons>();
            foreach (var dragon in dragons)
            {
                int health = 0;
                double damage = 0;

                Regex healthCalc = new Regex(@"[^0-9\*\/\+\-\.]");

                foreach (Match item in healthCalc.Matches(dragon))
                {

                    health += (int)(char.Parse(item.Value));
                }

                Regex damageCalc = new Regex(@"[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?");

                foreach (Match item in damageCalc.Matches(dragon))
                {
                    double currDigit = double.Parse(item.Value);
                    damage += currDigit;
                }

                foreach (var ch in dragon)
                {
                    if (ch == '*')
                    {
                        damage *= 2;
                    }
                    if (ch == '/' && damage != 0)
                    {
                        damage /= 2;
                    }
                }

                dragonsList.Add(new Dragons(dragon, health, damage));
            }

            foreach (var dragon in dragonsList.OrderBy(x=>x.Name))
            {
                Console.WriteLine(dragon.ToString()); 
            }
        }

        class Dragons
        {
            public string Name { get; set; }

            public int Health { get; set; }

            public double Damage { get; set; }

            public Dragons(string name, int health, double damage)
            {
                this.Name = name;
                this.Health = health;
                this.Damage = damage;
            }

            public override string ToString()
            {
                return $"{Name} - {Health} health, {Damage:f2} damage";

            }
        }
    }
}
