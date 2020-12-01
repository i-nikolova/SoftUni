using System;
using System.Threading;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceStrawberry = 3.50;
            const double priceBlueberry = 5.00;

            int rows = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int countStrawberry = 0;
            int countBlueberry = 0;

            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= position; j++)
                {
                    if (i % 2 != 0)
                    {
                        countStrawberry++;
                    }
                    if (i % 2 == 0)
                    {
                        if (j % 3 != 0)
                        {
                            countBlueberry++;
                        }
                    }
                }
            }
            double totalPrice = countBlueberry * priceBlueberry + countStrawberry * priceStrawberry;
            double priceSelled = totalPrice * 0.80;
            Console.WriteLine($"Total: {priceSelled:f2} lv.");
        }
    }
}
