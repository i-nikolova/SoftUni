using System;
using System.Dynamic;

namespace _01._Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceFlour = double.Parse(Console.ReadLine());
            double qtyFlour = double.Parse(Console.ReadLine());
            double qtySugar = double.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int maia = int.Parse(Console.ReadLine());

            double priceSugar = priceFlour * 0.75;
            double priceEggs = priceFlour * 1.10;
            double priceMaia = priceSugar * 0.20;

            double totalFlour = qtyFlour * priceFlour;
            double totalSugar = qtySugar * priceSugar;
            double totalEggs = eggs * priceEggs;
            double totalMaia = maia * priceMaia;

            double total = totalEggs + totalFlour + totalMaia + totalSugar;

            Console.WriteLine($"{total:f2}");
        }
    }
}
