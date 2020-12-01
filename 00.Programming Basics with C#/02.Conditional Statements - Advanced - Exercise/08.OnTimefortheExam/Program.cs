using System;

namespace _08.OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrived = int.Parse(Console.ReadLine());
            int minuteArrived = int.Parse(Console.ReadLine());
            int difference = 0;
            int minutes = 0;
            int hour = 0;

            minutesExam += hourExam * 60;
            minuteArrived += hourArrived* 60;

            if (minuteArrived>minutesExam)
            {
                difference = minuteArrived - minutesExam;
                if (difference < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (minuteArrived < minutesExam)
            {
                difference = minutesExam - minuteArrived;
                if (difference<=30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference >30 && difference <60 )
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
            }



        }
    }
}
