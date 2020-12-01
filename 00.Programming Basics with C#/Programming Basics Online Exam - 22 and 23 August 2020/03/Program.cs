using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string period = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price = 0;

            switch (period)
            {
                case "march":
                case "april":
                case "may":
                    switch (time)
                    {
                        case "day":
                            price = 10.50;
                            break;
                        case "night":
                            price = 8.4;
                            break;
                        default:
                            break;
                    }
                    break;
                case "june":
                case "july":
                case "august":
                    switch (time)
                    {
                        case "day":
                            price = 12.60;
                            break;
                        case "night":
                            price = 10.20;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            if (people >=4)
            {
                price *= 0.9;
            }
            if (hours >=5)
            {
                price *= 0.5;
            }

            double totalPrice = price * people*hours;

            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {totalPrice:f2}");
        }
    }
}
