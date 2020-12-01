using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, string> peopleRegistered = new Dictionary<string, string>();
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "register":
                        if (peopleRegistered.ContainsKey(cmdArgs[1]))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {peopleRegistered[cmdArgs[1]]}");
                        }
                        else
                        {
                            peopleRegistered.Add(cmdArgs[1], cmdArgs[2]);
                            Console.WriteLine($"{cmdArgs[1]} registered {cmdArgs[2]} successfully");
                        }
                        break;
                    case "unregister":
                        if (!peopleRegistered.ContainsKey(cmdArgs[1]))
                        {
                            Console.WriteLine($"ERROR: user {cmdArgs[1]} not found");
                        }
                        else
                        {
                            peopleRegistered.Remove(cmdArgs[1]);
                            Console.WriteLine($"{cmdArgs[1]} unregistered successfully");
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (var pair in peopleRegistered)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
