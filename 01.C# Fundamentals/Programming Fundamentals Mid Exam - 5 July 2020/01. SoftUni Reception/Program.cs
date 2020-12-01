using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsAnswerPerHour = 0;

            for (int i = 1; i <= 3; i++)
            {
                studentsAnswerPerHour += int.Parse(Console.ReadLine());
            }

            int studentsCount = int.Parse(Console.ReadLine());

            int hours = 0;

            while (studentsCount > 0)
            {
                studentsCount -= studentsAnswerPerHour;
                hours++;
                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
