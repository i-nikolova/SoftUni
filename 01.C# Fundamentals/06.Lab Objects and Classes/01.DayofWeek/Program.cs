using System;
using System.Globalization;

namespace _01.DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime dayOfWeek = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dayOfWeek.DayOfWeek);
        }
    }
}
