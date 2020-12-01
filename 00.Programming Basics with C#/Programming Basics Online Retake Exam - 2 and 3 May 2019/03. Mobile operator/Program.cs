using System;

namespace _03._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string contractType = Console.ReadLine();
            string mobileNet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double price = 0;

            if (years == "one")
            {
                switch (contractType)
                {
                    case "Small":
                        price = 9.98;
                        break;
                    case "Middle":
                        price = 18.99;
                        break;
                    case "Large":
                        price = 25.98;
                        break;
                    case "ExtraLarge":
                        price = 35.99;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (contractType)
                {
                    case "Small":
                        price = 8.58;
                        break;
                    case "Middle":
                        price = 17.09;
                        break;
                    case "Large":
                        price = 23.59;
                        break;
                    case "ExtraLarge":
                        price = 31.79;
                        break;
                    default:
                        break;
                }
            }
            if (mobileNet == "yes")
            {
                if (price<=10)
                {
                    price += 5.50;
                }
                else if (price > 10 && price<=30)
                {
                    price += 4.35;
                }
                else
                {
                    price += 3.85;
                }
            }
            if (years == "two")
            {
                price *= 0.9625;
            }

            double totalPrice = price * months;

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
