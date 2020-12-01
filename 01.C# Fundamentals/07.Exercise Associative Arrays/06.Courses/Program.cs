using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> cousess = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input=Console.ReadLine())!="end")
            {
                string[] cmdArgs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                if (cousess.ContainsKey(cmdArgs[0]))
                {
                    cousess[cmdArgs[0]].Add(cmdArgs[1]);
                }
                else
                {
                    cousess.Add(cmdArgs[0], new List<string>() { cmdArgs[1] });
                }
            }
            cousess = cousess.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in cousess)
            {
                pair.Value.Sort();
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");
                foreach (var name in pair.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
                
            }
        }
    }
}
