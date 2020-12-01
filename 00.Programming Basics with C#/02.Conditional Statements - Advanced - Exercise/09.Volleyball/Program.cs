using System;

namespace _9.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            double numberOfholidays = double.Parse(Console.ReadLine());
            double numberOfweekends = double.Parse(Console.ReadLine());
            double weeksInYear = 48;

            double weeksInSofia = weeksInYear - numberOfweekends;
            double gamesWeekendsInSofia = (weeksInSofia * 3 )/ 4;
            double gamesHolidays = (numberOfholidays * 2) / 3;
            double gamesInHometown = numberOfweekends;

            double totalGames = gamesHolidays + gamesInHometown + gamesWeekendsInSofia;

            if (typeYear == "leap")
            {
                totalGames += totalGames * 0.15;
            }

            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
