using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
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
                if (command[0] == "Delete")
                {
                    numbers=CommandDelete(numbers, int.Parse(command[1]));
                }
                else
                {
                    numbers=CommandInsert(numbers, int.Parse(command[1]), int.Parse(command[2]));
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> CommandInsert(List<int> numbers, int element, int position)
        {
            numbers.Insert(position, element);
            return numbers;
        }

        private static List<int> CommandDelete(List<int> numbers, int item)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.Remove(item);
            }
            return numbers;
        }
    }
}
