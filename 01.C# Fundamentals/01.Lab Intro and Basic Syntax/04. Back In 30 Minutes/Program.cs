using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            int timeAfter30Minutes = hour * 60 + minute + 30;
            int hourAfter = timeAfter30Minutes / 60;
            if (hourAfter >23)
            {
                hourAfter = 0;
            }
            int minutesAfter = timeAfter30Minutes % 60;
            Console.WriteLine($"{hourAfter}:{minutesAfter:d2}");
        }
    }
}
