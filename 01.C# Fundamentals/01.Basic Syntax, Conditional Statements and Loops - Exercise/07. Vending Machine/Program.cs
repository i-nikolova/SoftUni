using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            const double nutsPrice = 2;
            const double waterPrice = 0.7;
            const double CrispsPrice = 1.5;
            const double SodaPrice = 0.8;
            const double cokePrice = 1;

            string input = Console.ReadLine();
            double sum = 0;
            bool moneyNotEnought = false;

            while (input != "Start")
            {
                double moneyInserted = double.Parse(input);
                switch (moneyInserted)
                {
                    case 0.1:
                        sum += moneyInserted;
                        break;
                    case 0.2:
                        sum += moneyInserted;
                        break;
                    case 0.5:
                        sum += moneyInserted;
                        break;
                    case 1.0:
                        sum += moneyInserted;
                        break;
                    case 2.0:
                        sum += moneyInserted;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {moneyInserted}");
                        break;
                }
                input = Console.ReadLine();
            }
            while (true)
            {
                
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                switch (input)
                {
                    case "Nuts":
                        if (sum>=nutsPrice)
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            sum -= nutsPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        break;
                    case "Water":
                        if (sum >= waterPrice)
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            sum -= waterPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        break;
                    case "Crisps":
                        if (sum >= CrispsPrice)
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            sum -= CrispsPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        break;
                    case "Soda":
                        if (sum >= SodaPrice)
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            sum -= SodaPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        break;
                    case "Coke":
                        if (sum >= cokePrice)
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            sum -= cokePrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
