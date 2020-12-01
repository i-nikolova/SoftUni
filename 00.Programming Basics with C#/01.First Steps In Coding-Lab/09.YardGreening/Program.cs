using System;
using System.Reflection.Metadata;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForKvM = 7.61;
            double discount = 0.18;
            double yardSize = double.Parse(Console.ReadLine());
            double fullPrice = ( yardSize * priceForKvM );
            double discountPrice = discount * fullPrice;
            double finalPrice = fullPrice - discountPrice;


            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discountPrice} lv.");



        }
    }
}
