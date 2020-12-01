using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while ((input=Console.ReadLine()) !="end")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    numbers = CommandAdd(numbers, int.Parse(command[1]));
                }
                else
                {
                    numbers = CommandPutPeopleInWaggons(numbers,int.Parse(command[0]),capacity);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> CommandPutPeopleInWaggons(List<int> numbers, int people, int capacity)
        {
            bool isPlaced = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]+people<=capacity)
                {
                    numbers[i] += people;
                    isPlaced = true;
                    break;
                }
            }
            return numbers;
        }

        private static List<int> CommandAdd(List<int> numbers, int peopleInWaggon)
        {
            numbers.Add(peopleInWaggon);
            return numbers;
        }
    }
}
