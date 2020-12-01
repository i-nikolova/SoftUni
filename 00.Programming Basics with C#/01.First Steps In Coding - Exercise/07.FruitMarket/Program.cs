using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberry = double.Parse(Console.ReadLine());
            double qtyBananas = double.Parse(Console.ReadLine());
            double qtyOranges = double.Parse(Console.ReadLine());
            double qtyRasberry = double.Parse(Console.ReadLine());
            double qtyStrawberry = double.Parse(Console.ReadLine());

            double priceRasberry = priceStrawberry * 0.5;
            double priceOranges = priceRasberry - (priceRasberry * 0.4);
            double priceBananas = priceRasberry - (priceRasberry * 0.8);

            double finalPrice = (qtyStrawberry * priceStrawberry) + (qtyBananas * priceBananas) + (qtyOranges * priceOranges) + (qtyRasberry * priceRasberry);


            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
