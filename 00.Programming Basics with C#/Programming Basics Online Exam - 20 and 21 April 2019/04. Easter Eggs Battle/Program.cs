﻿using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsPlayerOne = int.Parse(Console.ReadLine());
            int eggsPlayerTwo= int.Parse(Console.ReadLine());
            string winner = Console.ReadLine();

            while (winner != "End of battle")
            {
                if (winner=="one")
                {
                    eggsPlayerTwo--;
                }
                else if (winner == "two")
                {
                    eggsPlayerOne--;
                }

                if (eggsPlayerOne==0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsPlayerTwo} eggs left.");
                    break;
                }
                else if (eggsPlayerTwo==0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsPlayerOne} eggs left.");
                    break;
                }

                winner = Console.ReadLine();
            }
            if (eggsPlayerOne>0 && eggsPlayerTwo >0)
            {
                Console.WriteLine($"Player one has {eggsPlayerOne} eggs left.");
                Console.WriteLine($"Player two has {eggsPlayerTwo} eggs left.");

            }

        }
    }
}
