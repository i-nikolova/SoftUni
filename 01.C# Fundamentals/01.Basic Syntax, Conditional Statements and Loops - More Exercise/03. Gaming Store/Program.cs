using System;
using System.ComponentModel;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutFall 4   $39.99
            //CS: OG  $15.99
            //Zplinter Zell	$19.99
            //Honored 2   $59.99
            //RoverWatch  $29.99
            //RoverWatch Origins Edition  $39.99

            double budget = double.Parse(Console.ReadLine());
            string gameType = Console.ReadLine();
            double gamePrice = 0;
            double moneySpend = 0;
            bool noMoreMoney = false;

            while (gameType != "Game Time")
            {
                switch (gameType)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (gamePrice > budget)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    budget -= gamePrice;
                    moneySpend += gamePrice;
                    Console.WriteLine($"Bought {gameType}");
                    if (budget == 0)
                    {
                        noMoreMoney = true;
                        Console.WriteLine("Out of money!");
                    }
                }
                if (noMoreMoney)
                {
                    break;
                }
                else
                {
                    gameType = Console.ReadLine();
                }
            }

            if (!noMoreMoney)
            {

                Console.WriteLine($"Total spent: ${Math.Round(moneySpend,2)}. Remaining: ${Math.Round(budget,2)}");
            }


        }
    }
}
