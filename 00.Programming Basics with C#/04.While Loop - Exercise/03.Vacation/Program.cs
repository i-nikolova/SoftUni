using System;
using System.Reflection.Metadata;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            int countSpend = 0;
            int countDays = 0;
            while (moneyAvailable < tripPrice)
            {

                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                countDays++;
                if (action == "spend")
                {
                    countSpend++;
                    moneyAvailable -= money;
                    if (moneyAvailable < 0)
                    {
                        moneyAvailable = 0;
                    }
                    if (countSpend == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{countDays}");
                        break;
                    }
                }
                else if (action == "save")
                {
                    countSpend = 0;
                    moneyAvailable += money;
                }
            }
            if (moneyAvailable >= tripPrice)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }

        }
    }
}
