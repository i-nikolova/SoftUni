using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int currIndex = 0;
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Forward":
                        int steps = int.Parse(cmdArgs[1]);
                        if (currIndex+steps<=houses.Count-1)
                        {
                            currIndex += steps;
                            houses.RemoveAt(currIndex);
                        }
                        break;
                    case "Back":
                        int stepsBack = int.Parse(cmdArgs[1]);
                        if (currIndex - stepsBack >=0)
                        {
                            currIndex -= stepsBack;
                            houses.RemoveAt(currIndex);
                        }
                        break;
                    case "Gift":
                        int index = int.Parse(cmdArgs[1]);
                        int houseNumber = int.Parse(cmdArgs[2]);
                        if (index>=0 && index<=houses.Count-1)
                        {
                            houses.Insert(index, houseNumber);
                            currIndex = index;
                        }
                        break;
                    case "Swap":
                        int firstIndex = houses.IndexOf(int.Parse(cmdArgs[1]));
                        int secondIndex = houses.IndexOf(int.Parse(cmdArgs[2]));
                        if (firstIndex >= 0 && firstIndex <= houses.Count - 1 && secondIndex >= 0 && secondIndex <= houses.Count - 1)
                        {
                            int firstIndexValue = houses[firstIndex];
                            int secondIndexValue = houses[secondIndex];

                            houses[firstIndex] = secondIndexValue;
                            houses[secondIndex] = firstIndexValue;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Position: { currIndex}");
            Console.WriteLine($"{string.Join(", ",houses)}");


        }
    }
}
