using System;
using System.Collections.Generic;

using System.Linq;


namespace _03.Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "Include":
                        CommandInclude(shops, cmdArgs[1]);
                        break;
                    case "Visit":
                        if (cmdArgs[1] == "first")
                        {
                            CommandVisitFirst(shops, int.Parse(cmdArgs[2]));
                        }
                        else
                        {
                            CommandVisitLast(shops, int.Parse(cmdArgs[2]));
                        }
                        break;
                    case "Prefer":
                        CommandPrefer(shops, int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    case "Place":
                        CommandPlace(shops, cmdArgs[1], int.Parse(cmdArgs[2]));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));

        }

        private static void CommandPlace(List<string> shops, string shop, int index)
        {
            if (index >= 0 && index < shops.Count)
            {
                shops.Insert(index + 1, shop);
            }
        }

        private static void CommandPrefer(List<string> shops, int shopIndexOne, int shopIndexTwo)
        {
            if ((shopIndexOne >= 0 && shopIndexOne < shops.Count) &&
                (shopIndexTwo >= 0 && shopIndexTwo < shops.Count))
            {
                string shopOneName = shops[shopIndexOne];
                string shopTwoName = shops[shopIndexTwo];

                shops[shopIndexOne] = shopTwoName;
                shops[shopIndexTwo] = shopOneName;
            }
        }

        private static void CommandVisitLast(List<string> shops, int number)
        {
            if (shops.Count - number >= 0)
            {

                shops.RemoveRange(shops.Count - number, number);
            }
        }

        private static void CommandVisitFirst(List<string> shops, int number)
        {
            if (number <= shops.Count)
            {
                shops.RemoveRange(0, number);
            }

        }

        private static void CommandInclude(List<string> shops, string shop)
        {
            shops.Add(shop);
        }
    }
}
