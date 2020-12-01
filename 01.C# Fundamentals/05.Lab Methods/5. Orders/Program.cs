using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            Order(product, qty);
        }

        static void Order (string product, int qty)
        {
            double price = 0;
            double total = 0;
            switch (product)
            {

                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                default:
                    break;
            }
            total = price * qty;
            Console.WriteLine($"{total:f2}");
        }
    }
}
