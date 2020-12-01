using System;
using System.Linq;

namespace _03.AngryPet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                   .Select(int.Parse).ToArray();
            int startIndex = int.Parse(Console.ReadLine());
            int entryPoint = priceRatings[startIndex];
            string typeOfItems = Console.ReadLine();
            string typeOfPriceRatings = Console.ReadLine();

            int leftSum = 0;
            int rightSum = 0;
            //left
            for (int i = 0; i < startIndex; i++)
            {
                if (typeOfPriceRatings=="positive" && priceRatings[i]<=0)
                {
                    continue;
                }
                if (typeOfPriceRatings == "negative" && priceRatings[i] >= 0)
                {
                    continue;
                }
                if (typeOfItems=="cheap" && priceRatings[i]>=entryPoint)
                {
                    continue;
                }
                if (typeOfItems == "expensive" && priceRatings[i] < entryPoint)
                {
                    continue;
                }

                leftSum += priceRatings[i];

            }
            for (int i = startIndex+1; i < priceRatings.Length; i++)
            {
                if (typeOfPriceRatings == "positive" && priceRatings[i] <= 0)
                {
                    continue;
                }
                if (typeOfPriceRatings == "negative" && priceRatings[i] >= 0)
                {
                    continue;
                }
                if (typeOfItems == "cheap" && priceRatings[i] >= entryPoint)
                {
                    continue;
                }
                if (typeOfItems == "expensive" && priceRatings[i] < entryPoint)
                {
                    continue;
                }

                rightSum += priceRatings[i];

            }

            if (rightSum>leftSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
            else
            {
                Console.WriteLine($"Left - {leftSum}");
            }

        }
    }
}
