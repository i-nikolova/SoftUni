using System;

namespace _01.Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEggs = priceFlour * 0.75;
            double priceMilk = (priceFlour * 1.25) / 4;

            int countEggs = 0;
            int countCozonacs = 0;

            while (budget - (priceFlour + priceEggs + priceMilk) > 0)
            {
                countCozonacs++;
                countEggs += 3;
                budget -= priceFlour + priceEggs + priceMilk;
                if (countCozonacs % 3 == 0)
                {
                    countEggs -= countCozonacs - 2;
                }
            }

            Console.WriteLine($"You made {countCozonacs} cozonacs! Now you have {countEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
