using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int daysPerBook = int.Parse(Console.ReadLine());

            double hoursPerBook = pagesInBook / pagesPerHour;
            double hoursPerDay = hoursPerBook / daysPerBook;

            Console.WriteLine($"{hoursPerDay:f2}") ;
        }
    }
}
