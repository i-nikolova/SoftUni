using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int countWins = 0;
            int countLosts = 0;
            double totalMoney = 0;
            int daysCounted = 0;
            while (daysCounted < days)
            {
                string sport = Console.ReadLine();
                string result = Console.ReadLine();
                int winsPerDay = 0;
                int LostPerDay = 0;
                double moneyWin = 0;
                while (true)
                {
                    if (result == "win")
                    {
                        countWins++;
                        winsPerDay++;
                        moneyWin += 20;
                    }
                    else
                    {
                        countLosts++;
                        LostPerDay++;
                    }

                    sport = Console.ReadLine();
                    if (sport == "Finish")
                    {
                        break;
                    }
                    result = Console.ReadLine();

                }
                if (winsPerDay > LostPerDay)
                {
                    moneyWin *= 1.1;
                }

                daysCounted++;
                totalMoney += moneyWin;
            }
            if (countWins > countLosts)
            {
                totalMoney *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else if (countLosts > countWins)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }


        }

    }
}
