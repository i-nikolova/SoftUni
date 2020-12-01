using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string country = Console.ReadLine();
                if (country=="End")
                {
                    break;
                }
                double tripPrice = double.Parse(Console.ReadLine());
                double totalMoneySaved = 0;
                while (totalMoneySaved<tripPrice)
                {
                    double moneySaved = double.Parse(Console.ReadLine());
                    totalMoneySaved += moneySaved;
                }
                Console.WriteLine($"Going to {country}!");

            }
        }
    }
}
