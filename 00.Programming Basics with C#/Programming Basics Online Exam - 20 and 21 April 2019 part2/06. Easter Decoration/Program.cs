using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceEgg = 1.5;
            const double priceWreath = 3.8;
            const double priceBunny = 7;
            int clients = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < clients; i++)
            {
                int countProduct = 0;
                double totalPerClient = 0;
                string product = Console.ReadLine();
                while (product != "Finish")
                {
                    
                    if (product == "basket")
                    {
                        countProduct++;
                        totalPerClient += priceEgg;
                    }
                    else if (product == "wreath")
                    {
                        countProduct++;
                        totalPerClient += priceWreath;
                    }
                    else
                    {
                        countProduct++;
                        totalPerClient += priceBunny;
                    }
                    
                    product = Console.ReadLine();
                }
                if (countProduct % 2 == 0)
                {
                    totalPerClient *= 0.8;
                }
                total += totalPerClient;
                Console.WriteLine($"You purchased {countProduct} items for {totalPerClient:f2} leva.");
            }
            double avgTotal = total * 1.0 / clients;
            Console.WriteLine($"Average bill per client is: {avgTotal:f2} leva.");
        }
    }
}
