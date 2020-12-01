using System;

namespace LabFirstStepsInCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            double currValue = 1.79549;
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * currValue;

            Console.WriteLine($"{bgn}");

        }
    }
}
