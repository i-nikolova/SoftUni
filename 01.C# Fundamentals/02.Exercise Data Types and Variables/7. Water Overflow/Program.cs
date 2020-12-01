using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int capacity = 255;
            int numberOfPourings = int.Parse(Console.ReadLine());
            int totalLiters = 0;
            for (int i = 0; i < numberOfPourings; i++)
            {
                int littersPoured = int.Parse(Console.ReadLine());
                if (capacity - littersPoured-totalLiters <0)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalLiters += littersPoured;
                }

            }
            Console.WriteLine(totalLiters);
        }
    }
}
