using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodBuyed = int.Parse(Console.ReadLine());
            int foodInGrams = foodBuyed * 1000;
            string input = Console.ReadLine();
            while (input != "Adopted")
            {
                int foodPerServing = int.Parse(input);
                foodInGrams -= foodPerServing;
                input = Console.ReadLine();
            }
            if (foodInGrams >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGrams} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodInGrams * -1} grams more.");
            }
        }
    }
}
