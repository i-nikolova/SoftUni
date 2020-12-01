using System;
using System.Xml.Schema;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double videoCardPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int qtyRam = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double total = cpuPrice + videoCardPrice;
            total = total - total * discount;
            total += qtyRam * ramPrice;
            

            total *= 1.57;

            Console.WriteLine($"Money needed - {total:f2} leva.");

        }
    }
}
