using System;

namespace _02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int numbersOfWalks = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            int totalMinutesWalk = numbersOfWalks * minutesWalk;
            int totalCaloriesBurn = totalMinutesWalk * 5;
            double caloriesNeeded = caloriesPerDay * 0.5;

            if (totalCaloriesBurn>=caloriesNeeded)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesBurn:f0}.");
            }
            else
            {

                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesBurn:f0}.");
            }


        }
    }
}
