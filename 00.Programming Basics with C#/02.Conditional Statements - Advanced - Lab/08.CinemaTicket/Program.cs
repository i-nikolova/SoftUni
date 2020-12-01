using System;

namespace _08.CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int priceTicket = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    priceTicket = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    priceTicket = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    priceTicket = 16;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine(priceTicket);
        }
    }
}
