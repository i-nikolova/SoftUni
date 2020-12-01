using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int points = 0;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Game over")
            {
                string[] cmdArgs = input.Split("@", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "Shoot Left":
                        if (int.Parse(cmdArgs[1]) < 0 || int.Parse(cmdArgs[1]) >= targets.Count)
                        {
                            continue;
                        }
                        else
                        {
                            points += CommandShootLeft(targets, int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        }
                        break;
                    case "Shoot Right":
                        if (int.Parse(cmdArgs[1]) < 0 || int.Parse(cmdArgs[1]) >= targets.Count)
                        {
                            continue;
                        }
                        else
                        {
                           points+= CommandShootRight(targets, int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        }
                        break;
                    case "Reverse":
                        CommandReverse(targets);
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine(string.Join(" - ",targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");

        }

        private static void CommandReverse(List<int> targets)
        {
            targets.Reverse();
        }

        private static int CommandShootRight(List<int> targets, int index, int length)
        {
            while (length != 0)
            {
                if (index < targets.Count - 1)
                {
                    index++;
                    length--;
                }
                else if (index == targets.Count - 1)
                {
                    index = 0;
                    length--;
                }
            }

            if (targets[index] >= 5)
            {
                targets[index] -= 5;
                return 5;
            }
            else
            {
                targets[index] = 0;
                return targets[index];

            }
        }


        private static int CommandShootLeft(List<int> targets, int index, int length)
        {
            while (length != 0)
            {

                if (index > 0)
                {
                    index--;
                    length--;
                }
                else if (index == 0)
                {
                    index = targets.Count - 1;
                    length--;
                }
            }

            if (targets[index] >= 5)
            {
                targets[index] -= 5;
                return 5;
            }
            else
            {
                targets[index] = 0;
                return targets[index];

            }
        }
    }
}

