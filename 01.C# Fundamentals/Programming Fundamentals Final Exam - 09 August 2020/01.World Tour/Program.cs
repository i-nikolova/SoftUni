using System;

namespace _01.World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = string.Empty;

            while ((command=Console.ReadLine())!="Travel")
            {
                string[] cmdArgs = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0]=="Add Stop")
                {
                    if (int.Parse(cmdArgs[1])>=0 && int.Parse(cmdArgs[1])<=input.Length)
                    {
                        input = input.Insert(int.Parse(cmdArgs[1]), cmdArgs[2]);
                        Console.WriteLine(input);
                    }
                }
                else if (cmdArgs[0] == "Remove Stop")
                {
                    if (int.Parse(cmdArgs[1]) >= 0 && int.Parse(cmdArgs[1]) <= input.Length && int.Parse(cmdArgs[2]) >= 0 && int.Parse(cmdArgs[2]) <= input.Length)
                    {
                        input = input.Remove(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]) - int.Parse(cmdArgs[1])+1);
                        Console.WriteLine(input);
                    }
                }
                else if (cmdArgs[0] == "Switch")
                {
                    if (input.Contains(cmdArgs[1]))
                    {
                        input = input.Replace((cmdArgs[1]), (cmdArgs[2]));
                        Console.WriteLine(input);
                    }
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
