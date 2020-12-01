using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            int singleProjectTime = 3;
            string name = Console.ReadLine();
            int projectsNumber = int.Parse(Console.ReadLine());
            int hoursNeeded = projectsNumber * singleProjectTime;

            Console.WriteLine($"The architect {name} will need {hoursNeeded} hours to complete {projectsNumber} project/s.");


        }
    }
}
