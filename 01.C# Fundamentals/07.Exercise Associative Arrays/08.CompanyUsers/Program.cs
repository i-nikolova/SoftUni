using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                if (employees.ContainsKey(cmdArgs[0]))
                {
                    if (employees[cmdArgs[0]].Contains(cmdArgs[1]))
                    {
                        continue;
                    }
                    else
                    {
                        employees[cmdArgs[0]].Add(cmdArgs[1]);
                    }
                }
                else
                {
                    employees.Add(cmdArgs[0], new List<string>() { cmdArgs[1] });
                }
            }

            employees = employees.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var person in item.Value)
                {
                    Console.WriteLine($"-- {person}");
                }
            }
        }
    }
}
