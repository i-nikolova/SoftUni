using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "Urgent":
                        CommandUrgent(groceries,cmdArgs[1]);
                        break;
                    case "Unnecessary":
                        CommandUnnecessary(groceries,cmdArgs[1]);
                        break;
                    case "Correct":
                        CommandCorrect(groceries,cmdArgs[1], cmdArgs[2]);
                        break;
                    case "Rearrange":
                        CommandRearrange(groceries,cmdArgs[1]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ",groceries));

        }

        private static void CommandRearrange(List<string> groceries,string item)
        {
            if (groceries.Contains(item))
            {
                string itemValue = item;
                groceries.Remove(item);
                groceries.Add(item);
            }
        }

        private static void CommandCorrect(List<string> groceries,string oldItem, string newItem)
        {
            if (groceries.Contains(oldItem))
            {
                groceries[groceries.IndexOf(oldItem)] = newItem;
            }
        }

        private static void CommandUnnecessary(List<string> groceries,string item)
        {
            if (groceries.Contains(item))
            {
                groceries.Remove(item);
            }
        }

        private static void CommandUrgent(List<string> groceries,string item)
        {
            if (!groceries.Contains(item))
            {
                groceries.Insert(0, item);
            }
        }
    }
}
