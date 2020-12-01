using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double priceFriut = 0;
            
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            priceFriut = 2.50;
                            double fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "apple":
                            priceFriut = 1.20;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "orange":
                            priceFriut = 0.85;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "grapefruit":
                            priceFriut = 1.45;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "kiwi":
                            priceFriut = 2.7;
                           fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "pineapple":
                            priceFriut = 5.50;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "grapes":
                            priceFriut = 3.85;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;                        
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                    
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            priceFriut = 2.70;
                            double fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "apple":
                            priceFriut = 1.25;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "orange":
                            priceFriut = 0.90;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "grapefruit":
                            priceFriut = 1.60;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "kiwi":
                            priceFriut = 3;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "pineapple":
                            priceFriut = 5.60;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        case "grapes":
                            priceFriut = 4.2;
                            fullPrice = qty * priceFriut;
                            Console.WriteLine($"{fullPrice:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
          }
            

        }
    }
}
