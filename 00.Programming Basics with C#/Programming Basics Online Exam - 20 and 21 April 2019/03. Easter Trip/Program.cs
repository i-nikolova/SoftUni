using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int daysStaying = int.Parse(Console.ReadLine());
            double priceForOneNight = 0;
            double totalPrice = 0;


            switch (destination)
            {
               
                case "France":
                    switch (dates)
                    {
                        case "21-23":
                            priceForOneNight = 30;
                            break;
                        case "24-27":
                            priceForOneNight = 35;
                            break;
                        case "28-31":
                            priceForOneNight = 40;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Italy":
                    switch (dates)
                    {
                        case "21-23":
                            priceForOneNight = 28;
                            break;
                        case "24-27":
                            priceForOneNight = 32;
                            break;
                        case "28-31":
                            priceForOneNight = 39;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Germany":
                    switch (dates)
                    {
                        case "21-23":
                            priceForOneNight = 32;
                            break;
                        case "24-27":
                            priceForOneNight = 37;
                            break;
                        case "28-31":
                            priceForOneNight = 43;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            totalPrice = daysStaying * priceForOneNight;
            Console.WriteLine($"Easter trip to { destination} : { totalPrice:f2} leva.");
        }
    }
}
