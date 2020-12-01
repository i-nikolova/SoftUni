using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> itemsToBuy = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            double budget = double.Parse(Console.ReadLine());
            CheckIfIsValid(itemsToBuy);
            List<double> buyedItems = BuyingItems(itemsToBuy, budget);
            budget -= buyedItems.Sum();

            List<double> selledItems = buyedItems.Select(x => x * 1.4).ToList();
            

            double profit = selledItems.Sum() - buyedItems.Sum();
            budget += selledItems.Sum();
            foreach (var item in selledItems)
            {
                Console.Write($"{item:f2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:f2}");
            if (budget>=150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }

            
        }

        private static List<double> BuyingItems(List<string> itemsToBuy,double budget)
        {
            List<double> buyedItems = new List<double>();
            for (int i = 0; i < itemsToBuy.Count; i++)
            {
                string[] itemArgs = itemsToBuy[i].Split("->", StringSplitOptions.RemoveEmptyEntries);
                if (double.Parse(itemArgs[1])<=budget)
                {
                    budget -= double.Parse(itemArgs[1]);
                    buyedItems.Add(double.Parse(itemArgs[1]));
                }
            }
            return buyedItems;
        }

        private static void CheckIfIsValid(List<string> itemsToBuy)
        {
            for (int i = 0; i < itemsToBuy.Count; i++)
            {
                string[] itemArgs = itemsToBuy[i].Split("->", StringSplitOptions.RemoveEmptyEntries);
                bool isValid = true;
                switch (itemArgs[0])
                {
                    case "Clothes":
                        if (double.Parse(itemArgs[1]) > 50)
                        {
                            isValid = false;
                        }
                        break;
                    case "Shoes":
                        if (double.Parse(itemArgs[1]) > 35)
                        {
                            isValid = false;
                        }
                        break;
                    case "Accessories":
                        if (double.Parse(itemArgs[1]) > 20.50)
                        {
                            isValid = false;
                        }
                        break;
                    default:
                        break;
                }
                if (!isValid)
                {
                    itemsToBuy.RemoveAt(i--);
                }
            }
        }

    }
}
