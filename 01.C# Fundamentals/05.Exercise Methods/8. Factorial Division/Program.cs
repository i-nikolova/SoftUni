using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            double result = CalulateFactorial(first) * 1.0 / CalulateFactorial(second);
            Console.WriteLine($"{result:f2}");
        }

        static double CalulateFactorial(int number)
        {
            double factorial = 1;
            if (number == 0)
            {
                factorial = 0;
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
            }
            return factorial;
        }
    }
}
