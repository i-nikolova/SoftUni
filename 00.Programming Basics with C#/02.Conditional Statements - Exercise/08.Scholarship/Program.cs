using System;
using System.Runtime.InteropServices.ComTypes;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double scholorshipForExelentResult = Math.Floor(averageGrade * 25);
            double socialScholorship = Math.Floor(0.35 * minimalSalary);

            if (income >=minimalSalary && averageGrade >= 5.5 )
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholorshipForExelentResult} BGN");
            }
            else if (income >=minimalSalary && averageGrade < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimalSalary && averageGrade >=5.5 && socialScholorship<=scholorshipForExelentResult)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholorshipForExelentResult} BGN");
            }
            else if (income< minimalSalary && averageGrade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholorship} BGN");
            }
            else if (income < minimalSalary && averageGrade <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
