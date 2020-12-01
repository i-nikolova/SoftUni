using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int coins = 0;
            input *= 100;


            int change = (int)input;

            while (change > 0)
            {
                if (change >= 200)
                {
                    coins++;
                    change -= 200;
                }
                else if (change >= 100)
                {
                    coins++;
                    change -= 100;
                }
                else if (change >= 50)
                {
                    coins++;
                    change -= 50;
                }
                else if (change >= 20)
                {
                    coins++;
                    change -= 20;
                }
                else if (change >= 10)
                {
                    coins++;
                    change -= 10;
                }
                else if (change >= 5)
                {
                    coins++;
                    change -= 5;
                }
                else if (change >= 2)
                {
                    coins++;
                    change -= 2;
                }
                else
                {
                    coins++;
                    change -= 1;

                }
            }
            Console.WriteLine(coins);
        }
    }
}
