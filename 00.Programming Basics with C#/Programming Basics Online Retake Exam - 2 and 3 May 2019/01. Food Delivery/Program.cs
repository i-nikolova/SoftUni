using System;
using System.Xml.Schema;

namespace _01._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            const double chickenMenu = 10.35;
            const double fishMenu = 12.40;
            const double vegMenu = 8.15;
            const double delivery = 2.5; 

            int numberOfChickenMenus = int.Parse(Console.ReadLine());
            int numberOfFishMenus = int.Parse(Console.ReadLine());
            int numberOfvVegMenus = int.Parse(Console.ReadLine());

            double totalMenus = numberOfChickenMenus * chickenMenu + numberOfFishMenus * fishMenu + numberOfvVegMenus * vegMenu;
            double totalDesert = totalMenus * 0.20;

            double total = totalMenus + totalDesert + delivery;

            Console.WriteLine($"Total: {total:f2}");

        }
    }
}
