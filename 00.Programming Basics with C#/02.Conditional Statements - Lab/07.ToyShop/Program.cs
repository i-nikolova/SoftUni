using System;
using System.Threading.Channels;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePuzzle = 2.60;
            double priceDoll = 3;
            double priceBear = 4.10;
            double priceMinnion = 8.20;
            double priceTruck = 2;

            double priceTrip = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinnions = int.Parse(Console.ReadLine());
            int numberOfTucks = int.Parse(Console.ReadLine());
            double sales = numberOfPuzzles * pricePuzzle + 
                numberOfBears * priceBear + 
                numberOfDolls * priceDoll + 
                numberOfMinnions * priceMinnion + 
                numberOfTucks * priceTruck;


            if (numberOfBears + numberOfDolls + numberOfMinnions + numberOfPuzzles + numberOfTucks >= 50)
            {
                double discountSales = sales * 0.75;
                double rent = discountSales * 0.10;
                double profit = discountSales - rent;
                if (profit>=priceTrip)
                {
                    double moneyLeft = profit - priceTrip;
                    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
                }
                else
                {
                    double moneyNeeded = priceTrip - profit;
                    Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");     
                }
            }
            else
            {
                double rent = sales * 0.10;
                double profit = sales - rent;
                if (profit >= priceTrip)
                {
                    double moneyLeft = profit - priceTrip;
                    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
                }
                else
                {
                    double moneyNeeded = priceTrip - profit;
                    Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
                }
            }

        }
    }
}
