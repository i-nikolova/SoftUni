using System;
using System.Net;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodQty = double.Parse(Console.ReadLine());
            double totalCookies = 0;
            double dogFood = 0;
            double catFood = 0;
            for (int i = 1; i <= days; i++)
            {
                double foodEatedByDog = double.Parse(Console.ReadLine());
                double foodEatedByCat = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    double cookies = (foodEatedByDog + foodEatedByCat) * 1.0 * 0.10;
                    totalCookies += cookies;
                }
                dogFood += foodEatedByDog;
                catFood += foodEatedByCat;
            }
            double totalFood = dogFood + catFood;
            double avgFood = totalFood * 1.0 / foodQty * 100;
            double avgDogFood = dogFood * 1.0 / totalFood * 100;
            double avgCarFood = catFood * 1.0 / totalFood * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalCookies)}gr.");
            Console.WriteLine($"{avgFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{avgDogFood:f2}% eaten from the dog.");
            Console.WriteLine($"{avgCarFood:f2}% eaten from the cat.");

        }
    }
}
