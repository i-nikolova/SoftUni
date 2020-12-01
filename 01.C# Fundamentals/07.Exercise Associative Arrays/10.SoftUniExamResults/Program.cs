using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            string input = string.Empty;
            while ((input = Console.ReadLine())!="exam finished")
            {
                string[] cmdArgs = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                if (cmdArgs[1] != "banned")
                {
                    if (students.ContainsKey(cmdArgs[0]))
                    {
                        if (students[cmdArgs[0]].ContainsKey(cmdArgs[1]))
                        {
                            if (students[cmdArgs[0]][cmdArgs[1]] < int.Parse(cmdArgs[2]))
                            {
                                students[cmdArgs[0]][cmdArgs[1]] = int.Parse(cmdArgs[2]);
                            }

                        }
                        else
                        {
                            students[cmdArgs[0]].Add(cmdArgs[1], int.Parse(cmdArgs[2]));
                        }
                        if (submissions.ContainsKey(cmdArgs[1]))
                        {
                            submissions[cmdArgs[1]]++;
                        }
                        else
                        {
                            submissions.Add(cmdArgs[1], 1);
                        }


                    }
                    else
                    {
                        students.Add(cmdArgs[0], new Dictionary<string, int>()
                    { {cmdArgs[1], int.Parse(cmdArgs[2]) } });
                        if (submissions.ContainsKey(cmdArgs[1]))
                        {
                            submissions[cmdArgs[1]]++;
                        }
                        else
                        {
                            submissions.Add(cmdArgs[1], 1);
                            
                        }
                    }
                }
                else
                {
                    students.Remove(cmdArgs[0]);
                }

            }

            students = students.OrderByDescending(x=>x.Value.Sum(x=>x.Value)).ThenBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            Console.WriteLine("Results:");
            foreach (var pair in students)
            {
                Console.WriteLine($"{pair.Key} | {pair.Value.Sum(x=>x.Value)}");
            }
            submissions= submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            Console.WriteLine("Submissions:");
            foreach (var sub in submissions)
            {
                Console.WriteLine($"{sub.Key} - {sub.Value}");
            }
        }
    }
}
