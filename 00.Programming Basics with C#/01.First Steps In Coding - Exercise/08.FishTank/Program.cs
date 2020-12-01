using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int weigth = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double present = double.Parse(Console.ReadLine());

            double area = lenght * weigth * hight;
            double liters = area * 0.001;
            double litersNeeded = liters * (1 - (present / 100));

            Console.WriteLine($"{litersNeeded}");

        }
    }
}
