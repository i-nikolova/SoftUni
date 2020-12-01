using System;

namespace _04._Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEggs = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            int numberOfEggsSold = 0;
            bool notEnough = false;
            while (action != "Close")
            {
                int numberOfEggsAction = int.Parse(Console.ReadLine());
                if (action == "Buy")
                {
                    if (numberOfEggsAction > numberOfEggs)
                    {

                        Console.WriteLine($"Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {numberOfEggs}.");
                        notEnough = true;
                        break;
                    }
                    numberOfEggs -= numberOfEggsAction;
                    numberOfEggsSold += numberOfEggsAction;
                }
                else
                {
                    numberOfEggs += numberOfEggsAction;
                }
                action = Console.ReadLine();
            }
            if (!notEnough)
            {
                Console.WriteLine($"Store is closed!");
                Console.WriteLine($"{numberOfEggsSold} eggs sold.");
            }

        }
    }
}
