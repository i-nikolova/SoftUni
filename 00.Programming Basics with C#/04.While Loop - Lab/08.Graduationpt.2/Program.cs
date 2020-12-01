using System;

namespace _08.Graduationpt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            int currentGrade = 1;
            int numberOfFalledClasses = 0;
            double sumGrade = 0;

            while (currentGrade <= 12)
            {
                if (numberOfFalledClasses == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {currentGrade} grade");
                    break;
                }

                double grade = double.Parse(Console.ReadLine());
                
                
                if (grade < 4)
                {
                    numberOfFalledClasses++;
                    continue;
                }

                sumGrade += grade;
                currentGrade++;
            }
            
            if (numberOfFalledClasses!=2)
            {
                double avarageGrade = sumGrade / 12;
                Console.WriteLine($"{name} graduated. Average grade: {avarageGrade:f2}");
            }
            
        }
    }
}