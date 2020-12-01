using System;
using System.Runtime.CompilerServices;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pricePensils = 4.75; 
            const double pricePen = 1.8; 
            const double priceDrawingBook = 6.50; 
            const double priceNotebook = 2.5;

            int qtyPensil = int.Parse(Console.ReadLine());
            int qtyPen = int.Parse(Console.ReadLine());
            int qtyDrawingBook = int.Parse(Console.ReadLine());
            int qtyNotebook = int.Parse(Console.ReadLine());

            double totalPrice = qtyDrawingBook*1.0 * priceDrawingBook + qtyNotebook*1.0 * priceNotebook + qtyPen*1.0 * pricePen + qtyPensil*1.0 * pricePensils;
            totalPrice =totalPrice - totalPrice* 0.05;
            Console.WriteLine($"Your total is {totalPrice:f2}lv");

        }
    }
}
