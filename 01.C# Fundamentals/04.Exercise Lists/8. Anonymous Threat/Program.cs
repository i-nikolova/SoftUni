using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split();
                if (command[0] == "merge")
                {
                    CommandMerge(numbers, int.Parse(command[1]), int.Parse(command[2]));
                }
                else
                {
                    CommandDivide(numbers, int.Parse(command[1]), int.Parse(command[2]));

                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void CommandDivide(List<string> numbers, int index, int partitions)
        {

            string toDivide = numbers[index];
            numbers.RemoveAt(index);
            int toTake = toDivide.Length / partitions;
            List<string> temp = new List<string>();
            string toAdd = string.Empty;
            for (int i = 1; i < partitions; i++)
            {
                toAdd = toDivide.Substring(0, toTake);
                toDivide = toDivide.Substring(toTake);
                temp.Add(toAdd);
            }
            temp.Add(toDivide.Substring(0));
            numbers.InsertRange(index, temp);
        }

        private static void CommandMerge(List<string> numbers, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex > numbers.Count - 1)
            {
                startIndex = numbers.Count - 1;
            }
            if (endIndex > numbers.Count - 1)
            {
                endIndex = numbers.Count - 1;
            }
            if (endIndex < 0)
            {
                endIndex = 0;
            }
            if (startIndex < endIndex)
            {
                for (int i = startIndex + 1; i <= endIndex; i++)
                {
                    numbers[startIndex] += numbers[i];

                }
                numbers.RemoveRange(startIndex + 1, endIndex - startIndex);
            }
        }
    }
}
