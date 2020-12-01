using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i <=0; i++)
            {
                if (playerOne[i]>playerTwo[i])
                {
                    playerOne.Add(playerOne[i]);
                    playerOne.Add(playerTwo[i]);
                    playerOne.RemoveAt(i);
                    playerTwo.RemoveAt(i);

                }
                else if (playerOne[i] < playerTwo[i])
                {
                    playerTwo.Add(playerTwo[i]);
                    playerTwo.Add(playerOne[i]);
                    playerOne.RemoveAt(i);
                    playerTwo.RemoveAt(i);
                }
                else
                {
                    playerOne.RemoveAt(i);
                    playerTwo.RemoveAt(i);
                }
                if (playerOne.Count==0 || playerTwo.Count==0)
                {
                    break;
                }
                i--;
            }

            if (playerOne.Count==0)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }
        }
    }
}
