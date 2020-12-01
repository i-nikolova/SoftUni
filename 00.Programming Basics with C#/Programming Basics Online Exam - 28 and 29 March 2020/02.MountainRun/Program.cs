using System;

namespace _02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecunds = double.Parse(Console.ReadLine());

            double totalSeconds = distanceInMeters * timeInSecunds;
            double delay = Math.Floor(distanceInMeters / 50) *30;
            double fullTime = totalSeconds + delay;

            if (fullTime>=record)
            {
                double secondsNeeded = fullTime - record;
                Console.WriteLine($"No! He was {secondsNeeded:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {fullTime:f2} seconds.");
            }
        }
    }
}
