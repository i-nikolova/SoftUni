using System;

namespace _05._Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCake = int.Parse(Console.ReadLine());
            int totalFlour = 0;
            int totalSugar = 0;
            int maxFlour = int.MinValue;
            int maxSugar = int.MinValue;

            for (int i = 0; i < numberOfCake; i++)
            {

                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());
                totalFlour += flour;
                totalSugar += sugar;
                if (flour > maxFlour)
                {
                    maxFlour = flour;
                }
                if (sugar > maxSugar)
                {
                    maxSugar = sugar;
                }

            }

            double totalPackagesFlour = Math.Ceiling(totalFlour * 1.0 / 750);
            double totalPackagesSugar = Math.Ceiling(totalSugar * 1.0 / 950);

            Console.WriteLine($"Sugar: {totalPackagesSugar}");
            Console.WriteLine($"Flour: {totalPackagesFlour}");
            Console.WriteLine($"Max used flour is {maxFlour}" +
                $" grams, max used sugar is {maxSugar} grams.");
        }
    }
}
