using System;

namespace FirstStepsInCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            double inchesToSm = 2.54;
            double sm = double.Parse(Console.ReadLine());
            double inches = (sm * inchesToSm);
            Console.WriteLine(inches);
        }
    }
}
