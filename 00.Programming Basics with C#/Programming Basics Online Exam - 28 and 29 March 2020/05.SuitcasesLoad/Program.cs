using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            int suitcases = 0;
            string input = Console.ReadLine();

            while (input != "End")
            {

                double suitcasesCapacity = double.Parse(input);
                if ((suitcases + 1) % 3 == 0)
                {
                    suitcasesCapacity *= 1.1;
                }
                capacity -= suitcasesCapacity;

                if (capacity < 0)
                {
                    Console.WriteLine("No more space!");
                    break;

                }
                suitcases++;
                input = Console.ReadLine();
            }
            if (capacity >= 0)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {suitcases} suitcases loaded.");

        }
    }
}
