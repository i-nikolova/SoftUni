using System;

namespace _01.The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdvanture = int.Parse(Console.ReadLine());
            int countOfPlayes = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterNeeded = double.Parse(Console.ReadLine()) * daysOfAdvanture * countOfPlayes;
            double foodNeeded = double.Parse(Console.ReadLine()) * daysOfAdvanture * countOfPlayes;
            int countDaySpend = 0;
            double amountOfEnergy = double.Parse(Console.ReadLine());
            bool isFinished = false;

            while (groupEnergy - amountOfEnergy >= 0)
            {
                countDaySpend++;
                groupEnergy -= amountOfEnergy;
                if (groupEnergy==0)
                {
                    break;
                }
                if (countDaySpend % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    waterNeeded *= 0.70;
                }
                if (countDaySpend % 3 == 0)
                {
                    foodNeeded -= foodNeeded / countOfPlayes;
                    groupEnergy *= 1.10;
                }
                if (countDaySpend == daysOfAdvanture)
                {
                    isFinished = true;
                    break;
                }
                amountOfEnergy = double.Parse(Console.ReadLine());

            }

            if (isFinished)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodNeeded:f2} food and {waterNeeded:f2} water.");
            }
        }
    }
}
