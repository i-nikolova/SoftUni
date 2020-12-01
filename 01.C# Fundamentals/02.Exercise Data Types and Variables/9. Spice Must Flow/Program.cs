using System;

namespace _9._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingSpice = int.Parse(Console.ReadLine());
            int totalSpiceLeft = 0;
            int spiceLeft = 0;
            int countDaysInMine = 0;
            for (int i = startingSpice; i >=100; i-=10)
            {
                spiceLeft = i - 26;
                totalSpiceLeft += spiceLeft;
                countDaysInMine++;
            }
            if (totalSpiceLeft>=26)
            {
                totalSpiceLeft -= 26;
            }
            Console.WriteLine(countDaysInMine);
            Console.WriteLine(totalSpiceLeft);
        }
    }
}
