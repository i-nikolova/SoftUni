using System;
using System.Collections.Generic;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> peopleComming = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[2]== "not")
                {
                    if (peopleComming.Contains(input[0]))
                    {
                        peopleComming.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
                else
                {
                    if (peopleComming.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        peopleComming.Add(input[0]);
                    }
                }
            }
            foreach (string name in peopleComming)
            {
                Console.WriteLine(name);
            }
        }
    }
}
