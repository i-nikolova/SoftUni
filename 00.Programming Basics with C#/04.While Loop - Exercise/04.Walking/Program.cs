using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goalSteps = 10000;
            int totalSteps = 0;
            while (totalSteps < goalSteps)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsToHome;
                    break;
                }
                else
                {
                    int stepsMade = int.Parse(input);
                    totalSteps += stepsMade;
                }

            }

            if (totalSteps >= goalSteps)
            {
                int stepsOver = totalSteps - goalSteps;
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
            else
            {
                int stepsLeft = goalSteps - totalSteps;
                Console.WriteLine($"{stepsLeft} more steps to reach goal.");
            }


        }
    }
}
