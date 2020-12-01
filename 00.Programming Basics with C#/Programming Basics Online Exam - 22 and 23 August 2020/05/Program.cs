using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            const int everest = 8848;
            string takingBreak = Console.ReadLine();
            int countDays = 1;
            int totalMeters = 5364;
            bool isFailed = false;

            while (takingBreak != "END")
            {
                if (takingBreak=="Yes")
                {
                    countDays++;
                }
                if (countDays > 5)
                {
                    isFailed = true;
                    break;
                }
                int metersClimb = int.Parse(Console.ReadLine());
                totalMeters += metersClimb;
                if (totalMeters>=everest)
                {
                    isFailed = false;
                    break;
                }
                else
                {
                    isFailed = true;
                }
                
                
                takingBreak = Console.ReadLine();
            }

            if (isFailed)
            {
                Console.WriteLine($"Failed!");
                Console.WriteLine($"{totalMeters}");
            }
            else
            {
                Console.WriteLine($"Goal reached for {countDays} days!");
            }

        }
    }
}
