using System;

namespace _03._Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggSize = Console.ReadLine();
            string eggColor = Console.ReadLine();
            int numberOfEggs = int.Parse(Console.ReadLine());
            double priceForEgss = 0;

            switch (eggSize)
            {
                case "Large":
                    switch (eggColor)
                    {
                        case "Red":
                            priceForEgss = 16;
                            break;
                        case "Green":
                            priceForEgss = 12;
                            break;
                        case "Yellow":
                            priceForEgss = 9;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Medium":
                    switch (eggColor)
                    {
                        case "Red":
                            priceForEgss = 13;
                            break;
                        case "Green":
                            priceForEgss = 9;
                            break;
                        case "Yellow":
                            priceForEgss = 7;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Small":
                    switch (eggColor)
                    {
                        case "Red":
                            priceForEgss = 9;
                            break;
                        case "Green":
                            priceForEgss = 8;
                            break;
                        case "Yellow":
                            priceForEgss = 5;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            double totalPrice = priceForEgss * numberOfEggs;
            totalPrice -= totalPrice * 0.35;

            Console.WriteLine($"{totalPrice:f2} leva.");
        }
    }
}
