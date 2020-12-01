using System;

namespace _01.CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double pricePerOrder = 0;

            for (int i = 0; i < numberOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                pricePerOrder = Math.Round(days * capsulesCount * pricePerCapsule,2);
                totalPrice += pricePerOrder;
                Console.WriteLine($"The price for the coffee is: ${pricePerOrder:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
