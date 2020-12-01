using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "Change":
                        CommandChange(paintings, int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    case "Hide":
                        CommandHide(paintings, int.Parse(cmdArgs[1]));
                        break;
                    case "Switch":
                        CommandSwitch(paintings, int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    case "Insert":
                        CommandInsert(paintings, int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    case "Reverse":
                        paintings.Reverse();
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",paintings));
        }

        private static void CommandInsert(List<int> paintings, int index, int paintingNumber)
        {
            if (index >= 0 && index < paintings.Count - 1)
            {
                paintings.Insert(index + 1, paintingNumber);

            }
        }

        private static void CommandSwitch(List<int> paintings, int paintingNumber1, int paintingNumber2)
        {
            if (paintings.Contains(paintingNumber1) && paintings.Contains(paintingNumber2))
            {
                int indexPaintingOne = paintings.IndexOf(paintingNumber1);
                int indexPaintingTwo = paintings.IndexOf(paintingNumber2);

                paintings[indexPaintingOne] = paintingNumber2;
                paintings[indexPaintingTwo] = paintingNumber1;

            }
        }

        private static void CommandHide(List<int> paintings, int paintingNumber)
        {
            if (paintings.Contains(paintingNumber))
            {
                paintings.RemoveAt(paintings.IndexOf(paintingNumber));
            }
        }

        private static void CommandChange(List<int> paintings, int paintingNumber, int newNumber)
        {
            if (paintings.Contains(paintingNumber))
            {
                paintings[paintings.IndexOf(paintingNumber)] = newNumber;
            }
        }
    }
}
