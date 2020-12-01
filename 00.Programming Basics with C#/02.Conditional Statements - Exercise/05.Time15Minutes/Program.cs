using System;

namespace _05.Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            ;
            
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes >= 45)
            {
                hour += 1;
                if (hour==24)
                {
                    hour -= 24;
                }
                minutes += 15 - 60;
            }
            else
            {
                minutes += 15;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
