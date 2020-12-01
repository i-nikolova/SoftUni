using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        numbers = CommandAdd(numbers, int.Parse(command[1]));
                        break;
                    case "Insert":
                        numbers = CommandInsert(numbers, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Remove":
                        numbers = CommandRemove(numbers, int.Parse(command[1]));
                        break;
                    case "Shift":
                        if (command[1] == "left")
                        {
                            numbers = CommandShitLeft(numbers, int.Parse(command[2]));
                        }
                        else
                        {
                            numbers = CommandShitRight(numbers, int.Parse(command[2]));
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> CommandShitRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                for (int j = numbers.Count-1; j > 0; j--)
                {
                    numbers[j] = numbers[j-1];
                }
                numbers[0] = lastNumber;
            }

            
            return numbers;

        }

        private static List<int> CommandShitLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                for (int j = 1; j < numbers.Count; j++)
                {
                    numbers[j - 1] = numbers[j];
                }
                numbers[numbers.Count - 1] = firstNumber;
            }
            return numbers;

        }

        private static List<int> CommandRemove(List<int> numbers, int index)
        {
            if (index<0 || index>=numbers.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.RemoveAt(index);
            }
            return numbers;


        }

        private static List<int> CommandInsert(List<int> numbers, int number, int index)
        {
            if (index < 0 || index >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.Insert(index, number);
            }
            return numbers;


        }

        private static List<int> CommandAdd(List<int> numbers, int number)
        {
            numbers.Add(number);
            return numbers;
        }
    }
}
