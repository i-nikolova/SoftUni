using System;

namespace _09.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingmashine = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());
            double money = 0;
            double toysMoney = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0 && i>1 )
                {
                    money += 10*i/2;
                    money -= 1;
                }
                else
                {
                    toysMoney += priceToys;
                }
                
            }

            double moneySaved = toysMoney + money;
            if (priceWashingmashine<=moneySaved)
            {
                double moneyLeft = moneySaved - priceWashingmashine;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = priceWashingmashine - moneySaved;
                Console.WriteLine($"No! {moneyNeeded:f2}");

            }
        }
    }
}
