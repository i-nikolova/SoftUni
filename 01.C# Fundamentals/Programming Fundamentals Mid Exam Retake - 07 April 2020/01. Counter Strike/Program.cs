using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int countWonBattles = 0;
            bool notEnoughEnergy = false;
            while ((input = Console.ReadLine()) !="End of battle")
            {
                int distance = int.Parse(input);
                if (distance>energy)
                {
                    notEnoughEnergy = true;
                    Console.WriteLine($"Not enough energy! Game ends with { countWonBattles } won battles and { energy} energy");
                    break;
                }
                energy -= distance;
                countWonBattles++;
                if (countWonBattles%3==0)
                {
                    energy += countWonBattles;
                }

            }
            if (!notEnoughEnergy)
            {
                Console.WriteLine($"Won battles: {countWonBattles}. Energy left: {energy}");
            }

        }
    }
}
