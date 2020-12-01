using System;

namespace _06._Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalrice = 0;
            int day = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            for (int i = 1; i <= day; i++)
            {
                double totalParkingPrice = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        totalParkingPrice += 2.5;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        totalParkingPrice += 1.25;
                    }
                    else
                    {
                        totalParkingPrice += 1;
                    }
                }
                totalrice += totalParkingPrice;
                Console.WriteLine($"Day: {i} - {totalParkingPrice:f2} leva");
            }
            Console.WriteLine($"Total: {totalrice:f2} leva");
        }
    }
}
