using System;
using System.Threading;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxDiv = int.MinValue;

            if (n % 2 == 0)
            {
                maxDiv = 2;
            }
            if (n % 3 == 0)
            {
                maxDiv = 3;
            }
            if (n % 6 == 0)
            {
                maxDiv = 6;
            }
            if (n % 7 == 0)
            {
                maxDiv = 7;
            }
            if (n % 10 == 0)
            {
                maxDiv = 10;
            }
            if (maxDiv != int.MinValue)
            {
                Console.WriteLine($"The number is divisible by {maxDiv}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
