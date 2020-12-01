using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStudentTikets = 0;
            int totalKidTikets = 0;
            int totalStandartTikets = 0;
            int totalTicketsSale = 0;
            while (true)
            {

                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    break;
                }
                int freePlaces = int.Parse(Console.ReadLine());
                int totalPlaces = freePlaces;

                while (freePlaces >0)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "student":
                            totalStudentTikets++;
                            break;
                        case "kid":
                            totalKidTikets++;
                            break;
                        case "standard":
                            totalStandartTikets++;
                            break;
                    }
                    freePlaces--;
                    totalTicketsSale++;
                    
                }
                double movieSales = totalTicketsSale * 1.0 / totalPlaces * 100;
                Console.WriteLine($"{movieName} - {movieSales:f2}% full.");
            }
            int totalTickets = totalKidTikets + totalStandartTikets + totalStudentTikets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            double avgStudentTikets = totalStudentTikets*1.0 / totalTickets * 100;
            double avgKidTikets = totalKidTikets*1.0 / totalTickets * 100;
            double avgStandartTikets = totalStandartTikets * 1.0 / totalTickets * 100;

            Console.WriteLine($"{avgStudentTikets:f2}% student tickets.");
            Console.WriteLine($"{avgStandartTikets:f2}% standard tickets.");
            Console.WriteLine($"{avgKidTikets:f2}% kids tickets."); 

        }
    }
}

