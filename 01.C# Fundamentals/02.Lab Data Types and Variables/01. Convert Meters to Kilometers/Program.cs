using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            
            decimal kilometers = Convert.ToDecimal( meters / 1000.00);

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
