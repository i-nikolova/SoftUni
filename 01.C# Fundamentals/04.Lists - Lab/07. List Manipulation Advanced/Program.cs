using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            bool isChanged = false;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Contains":
                        CommandContains(numbers, int.Parse(command[1]));
                        break;
                    case "PrintEven":
                        CommandPrintEven(numbers);
                        break;
                    case "PrintOdd":
                        CommandPrintOdd(numbers);
                        break;
                    case "GetSum":
                        CommandGetSum(numbers);
                        break;
                    case "Filter":
                        CommandFilter(numbers, command[1], int.Parse(command[2]));
                        break;
                    case "Add":
                        CommandAdd(numbers, int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        isChanged = true;
                        CommandRemove(numbers, int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        CommandRemoveAt(numbers, int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        CommandInsert(numbers, int.Parse(command[1]), int.Parse(command[2]));
                        isChanged = true;
                        break;
                    default:
                        break;
                }  
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static void CommandContains(List<int> numbers, int v)
        {
            if (numbers.Contains(v))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        private static void CommandPrintEven(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                }

            }
            Console.WriteLine();
        }

        private static void CommandPrintOdd(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.Write($"{numbers[i]} ");
                }

            }
            Console.WriteLine();
        }

        private static void CommandGetSum(List<int> numbers)
        {
            Console.WriteLine(numbers.Sum());
        }

        private static void CommandFilter(List<int> numbers, string v1, int v2)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                switch (v1)
                {
                    case "<":
                        if (numbers[i] < v2)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        break;
                    case ">":
                        if (numbers[i] > v2)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        break;
                    case ">=":
                        if (numbers[i] >= v2)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        break;
                    case "<=":
                        if (numbers[i] <= v2)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
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

