using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"[sStTaArR]");
                int key = regex.Matches(input).Count;
                if (key>0)
                {
                    //input = regex.Replace(input, "");
                    StringBuilder sb = new StringBuilder();

                    for (int j = 0; j < input.Length; j++)
                    {
                        sb.Append((char)((int)(char)input[j] - key));
                    }

                    input = sb.ToString();
                }


                Regex messageDecryption = new Regex(@"@(?<planetName>[A-z][a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attacType>[AD])![@\-!:>]*->[@\-!:>]*(?<soldiersCount>\d+)");

                if (messageDecryption.IsMatch(input))
                {
                    string planetName =messageDecryption.Match(input).Groups["planetName"].Value;
                    string attack = messageDecryption.Match(input).Groups["attacType"].Value;
                    if (attack=="A")
                    {
                        attacked.Add(planetName);
                    }
                    else if (attack=="D")
                    {
                        destroyed.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            if (attacked.Count>0)
            {
                foreach (var planet in attacked.OrderBy(x=>x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            if (destroyed.Count > 0)
            {
                foreach (var planet in destroyed.OrderBy(x=>x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

        }
    }
}
