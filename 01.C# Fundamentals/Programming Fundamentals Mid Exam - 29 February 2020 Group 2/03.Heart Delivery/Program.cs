using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input = string.Empty;
            int cupidCurrIndex = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                cupidCurrIndex += int.Parse(cmdArgs[1]);
                if (cupidCurrIndex>houses.Count-1 || cupidCurrIndex < 0)
                {
                    cupidCurrIndex = 0;
                }
                if (houses[cupidCurrIndex]==0)
                {
                    Console.WriteLine($"Place {cupidCurrIndex} already had Valentine's day.");
                }
                else if (houses[cupidCurrIndex] -2 == 0)
                {
                    houses[cupidCurrIndex] -= 2;
                    Console.WriteLine($"Place { cupidCurrIndex} has Valentine's day.");
                }
                else
                {
                    houses[cupidCurrIndex] -= 2;
                }

            }

            int countFailedHouses = 0;

            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i]!=0)
                {
                    countFailedHouses++;
                }
            }

            Console.WriteLine($"Cupid's last position was {cupidCurrIndex}.");
            if (countFailedHouses==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {countFailedHouses} places.");
            }

        }
    }
}
