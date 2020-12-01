using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int minSeconds = int.MaxValue;
            string winnerName = "";
            int countGold = 0;
            int countSilver = 0;
            int countBronze = 0;
            while (name != "Finish")
            {
                
                int minutes = int.Parse(Console.ReadLine());
                int seconds = int.Parse(Console.ReadLine());
                int totalSeconds = minutes * 60 + seconds;
                if (totalSeconds>85 && totalSeconds<=120)
                {
                    countBronze++;
                }
                else if (totalSeconds>= 55 && totalSeconds <=85)
                {
                    countSilver++;
                }
                else if (totalSeconds<55)
                {
                    countGold++;
                }
                
                if (totalSeconds<minSeconds)
                {
                    minSeconds = totalSeconds;
                    winnerName = name;
                }
                name = Console.ReadLine();
            }

            
            Console.WriteLine($"With {minSeconds/60} minutes and {minSeconds%60} seconds {winnerName} is the winner of the day!");
            Console.WriteLine($"Today's prizes are {countGold} Gold {countSilver} Silver and {countBronze} Bronze cards!");
        }
    }
}
