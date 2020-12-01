using System;

namespace _07.WorldSwimmingPoolRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInseconds = double.Parse(Console.ReadLine());
            double distantInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double distantsInSeconds = distantInMeters * timeInSeconds;
            double delay = Math.Floor((distantInMeters / 15)) * 12.5;
            double fullTime = distantsInSeconds + delay;
            if (recordInseconds>fullTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {fullTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {fullTime-recordInseconds:f2} seconds slower.");
            }
            

        }
    }
}
