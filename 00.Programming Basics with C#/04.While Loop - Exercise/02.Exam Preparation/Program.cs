using System;
using System.Runtime.CompilerServices;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int countBagGrades = 0;
            int countTask = 0;
            string task = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());
            bool isFailed = false;
            int sumTasks = 0;
            string lastProblem = "";

            while (true)
            {
                if (grade <= 4)
                {
                    countBagGrades++;
                }
                if (countBagGrades == badGrades)
                {
                    isFailed = true;
                    break;
                }
                countTask++;
                sumTasks += grade;
                lastProblem = task;
                task = Console.ReadLine();
                if (task == "Enough")
                {
                    break;
                }
                grade = int.Parse(Console.ReadLine());
            }
            if (isFailed == true)
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
            }
            else
            {
                double avarage = sumTasks * 1.0 / countTask;
                Console.WriteLine($"Average score: {avarage:f2}");
                Console.WriteLine($"Number of problems: {countTask}");
                Console.WriteLine($"Last problem: {lastProblem}");

            }
        }
    }
}
