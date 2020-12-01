using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            
            BigInteger winnerSnowball = 0;
            int winnersnowballSnow = 0;
            int winnersnowballTime = 0;
            int winnetsnowballQuality = 0;
            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue>winnerSnowball)
                {
                    winnerSnowball = snowballValue;
                    winnersnowballSnow = snowballSnow;
                    winnersnowballTime = snowballTime;
                    winnetsnowballQuality = snowballQuality;
                }
                
            }
            Console.WriteLine($"{winnersnowballSnow} : {winnersnowballTime} = {winnerSnowball} ({winnetsnowballQuality})");


        }
    }
}
