using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine())!="end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                int startIndex = 0;
                int count = 0;
                if (cmdArgs.Length==2)
                {
                    count = int.Parse(cmdArgs[1]);
                }
                else
                {
                    startIndex = int.Parse(cmdArgs[2]);
                    count = int.Parse(cmdArgs[4]);
                }

                switch (command)
                {
                    case "reverse":
                       array= CommandReverse(array, startIndex, count);
                        break;
                    case "sort":
                        array = CommandSort(array, startIndex, count);
                        break;
                    case "remove":
                        CommandRemove(array, count);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ",array));
        }

        private static void CommandRemove(List<string> array, int count)
        {
            for (int i = count-1; i >=0 ; i--)
            {
                array.RemoveAt(i);
            }
        }

        private static List<string> CommandSort(List<string> array, int startIndex, int count)
        {
            List<string> sortedArray = new List<string>();
            for (int i = startIndex; i <startIndex+count; i++)
            {
                sortedArray.Add(array[i]);
            }
            sortedArray.Sort();
            array.RemoveRange(startIndex, count);
            array.InsertRange(startIndex, sortedArray);
            return array;
        }

        private static List<string> CommandReverse(List<string> array, int startIndex, int count)
        {
            List<string> reversedArray = new List<string>();
            for (int i = startIndex; i < startIndex+count; i++)
            {
                reversedArray.Add(array[i]);
            }
           reversedArray.Reverse();
            array.RemoveRange(startIndex, count);
            array.InsertRange(startIndex, reversedArray);
            return array;
        }
    }
}
