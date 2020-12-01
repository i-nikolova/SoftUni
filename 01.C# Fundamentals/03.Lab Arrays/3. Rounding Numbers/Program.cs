using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string doubleVariables = Console.ReadLine();
            double[] array = doubleVariables.Split(' ').Select(double.Parse).ToArray();

            foreach (double number in array)
            {
                int rounded = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(number)} => {Convert.ToDecimal(rounded)}");
            }
        }
    }
}
