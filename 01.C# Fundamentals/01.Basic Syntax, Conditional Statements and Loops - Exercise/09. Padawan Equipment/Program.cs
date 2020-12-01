using System;
using System.Threading;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightSabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            double TotalSum = 0;
            double freeBelts = (students / 6)*priceBelts;

            TotalSum = Math.Ceiling(students * 1.10) * (priceLightSabers) + (students* priceRobes )+ (students * priceBelts) - freeBelts;

            if (budget>=TotalSum)
            {
                double moneyLeft = budget - TotalSum;
                Console.WriteLine($"The money is enough - it would cost {TotalSum:f2}lv.");
            }
            else
            {
                double moneyNeeded = TotalSum - budget;
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
