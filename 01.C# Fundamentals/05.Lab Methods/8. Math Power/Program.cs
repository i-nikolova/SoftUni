using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double numer = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = MathPower(numer, power);
            Console.WriteLine(result);
        }

        static double MathPower (double number, int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
