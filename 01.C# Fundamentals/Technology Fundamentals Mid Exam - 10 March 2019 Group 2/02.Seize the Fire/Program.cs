using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fireCells = Console.ReadLine().Split("#", StringSplitOptions.RemoveEmptyEntries).ToList();
            int waterAmount = int.Parse(Console.ReadLine());
            double effordNeeded = 0;
            int totalFire = 0;
            CheckIfIsValid(fireCells);
            List<int> finishedCells = new List<int>();

            for (int i = 0; i < fireCells.Count; i++)
            {
                string[] cellArgs = fireCells[i].Split(" = ", StringSplitOptions.RemoveEmptyEntries);
                if (waterAmount>=int.Parse(cellArgs[1]))
                {
                    waterAmount -= int.Parse(cellArgs[1]);
                    finishedCells.Add(int.Parse(cellArgs[1]));
                    effordNeeded += int.Parse(cellArgs[1]) * 0.25;
                    totalFire+= int.Parse(cellArgs[1]);
                }
                if (waterAmount<=0)
                {
                    break;
                }
            }

            Console.WriteLine("Cells:");
            foreach (var cell in finishedCells)
            {
                Console.WriteLine($"- {cell}");
            }
            Console.WriteLine($"Effort: {effordNeeded:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }

        public static void CheckIfIsValid (List<string> fireCells)
        {
            for (int i = 0; i < fireCells.Count; i++)
            {
                bool isValid = true;
                string[] cellArgs = fireCells[i].Split(" = ", StringSplitOptions.RemoveEmptyEntries);
                switch (cellArgs[0])
                {
                    case "High":
                        if (int.Parse(cellArgs[1]) < 81 || int.Parse(cellArgs[1]) > 125)
                        {
                            isValid = false;
                        }
                        break;
                    case "Medium":
                        if (int.Parse(cellArgs[1]) < 51 || int.Parse(cellArgs[1]) > 80)
                        {
                            isValid = false;
                        }
                        break;
                    case "Low":
                        if (int.Parse(cellArgs[1]) < 1 || int.Parse(cellArgs[1]) > 50)
                        {
                            isValid = false;
                        }
                        break;
                    default:
                        break;
                }
                if (!isValid)
                {
                    fireCells.RemoveAt(i--);
                }
            }
        }
    }
}
