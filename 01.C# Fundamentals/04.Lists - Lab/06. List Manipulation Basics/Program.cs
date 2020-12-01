using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        CommandAdd(numbers, int.Parse(command[1]));
                        break;
                    case "Remove":
                        CommandRemove(numbers, int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        CommandRemoveAt(numbers, int.Parse(command[1]));
                        break;
                    case "Insert":
                        CommandInsert(numbers, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void CommandInsert(List<int> numbers, int index, int value)
        {
            numbers.Insert(value, index);
        }

        private static void CommandRemoveAt(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }

        private static void CommandRemove(List<int> numbers, int number)
        {
            numbers.Remove(number);
        }

        private static void CommandAdd(List<int> numbers, int number)
        {
            numbers.Add(number);
        }
    }
}
