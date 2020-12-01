using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            int numberRows = int.Parse(Console.ReadLine());
            int numberColumns = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            switch (ticketType)
            {
                case "Premiere":
                    totalPrice = numberColumns * numberRows * 12.00;
                    break;
                case "Normal":
                    totalPrice = numberColumns * numberRows * 7.50;
                    break;
                case "Discount":
                    totalPrice = numberColumns * numberRows * 5.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{totalPrice:f2} leva");


        }
    }
}
