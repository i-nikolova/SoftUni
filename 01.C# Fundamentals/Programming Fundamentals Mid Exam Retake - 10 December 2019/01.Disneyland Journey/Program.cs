using System;

namespace _01.Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            int journeyMoney = int.Parse(Console.ReadLine());
            int monthsToCollect = int.Parse(Console.ReadLine());

            double moneySaved = 0;

            for (int i = 1; i <= monthsToCollect; i++)
            {
                if (i !=1 && i%2==1)
                {
                    moneySaved -= moneySaved * 0.16;
                }
                if (i%4==0)
                {
                    moneySaved += moneySaved * 0.25;
                }
                moneySaved += journeyMoney * 0.25;
            }
            if (moneySaved>=journeyMoney)
            {
                double moneyLeft = moneySaved - journeyMoney;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyLeft:f2}lv. for souvenirs.");
            }
            else
            {
                double moneyNeeded = journeyMoney - moneySaved;
                Console.WriteLine($"Sorry. You need {moneyNeeded:f2}lv. more.");
            }
            
        }
    }
}
