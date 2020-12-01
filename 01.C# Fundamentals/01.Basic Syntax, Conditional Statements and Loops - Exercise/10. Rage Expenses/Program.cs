using System;
using System.Threading;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            double totalMoney = priceHeadset * (gamesLost / 2);
            totalMoney += priceMouse * (gamesLost / 3);
            totalMoney += priceKeyboard * (gamesLost / 6);
            totalMoney += priceDisplay * (gamesLost / 12);
                        
            Console.WriteLine($"Rage expenses: {totalMoney:f2} lv.");

        }
    }19.99
Reimen origin
RoverWatch
Zplinter Zell
Game Time2
1
3


2
1
3


}
