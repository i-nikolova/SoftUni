using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJury = int.Parse(Console.ReadLine());
            string project = Console.ReadLine();

            double totalMarks = 0;
            int countMarks = 0;

            while (project != "Finish")
            {
                double totalProjectMarks = 0;
                for (int i = 0; i < countJury; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    totalProjectMarks += mark;
                    countMarks++;
                }
                double avgProjectMark = totalProjectMarks * 1.00 / countJury;
                Console.WriteLine($"{project} - {avgProjectMark:f2}.");
                totalMarks += totalProjectMarks;
                project = Console.ReadLine();
            }
            double avgMarks = totalMarks * 1.00 / countMarks;
            Console.WriteLine($"Student's final assessment is {avgMarks:f2}.");


        }
    }
}
