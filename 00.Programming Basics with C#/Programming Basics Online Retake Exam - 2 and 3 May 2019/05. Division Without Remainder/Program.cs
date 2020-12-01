using System;
using System.Threading;

namespace _05._Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    countP1++;
                }
                if (number % 3 ==0)
                {
                    countP2++;
                }
                if (number % 4 == 0)
                {
                    countP3++;
                }
            }

            double avgP1 = countP1*1.0 / n * 100;
            double avgP2 = countP2 * 1.0 / n * 100;
            double avgP3 = countP3 * 1.0 / n * 100;

            Console.WriteLine($"{avgP1:f2}%");
            Console.WriteLine($"{avgP2:f2}%");
            Console.WriteLine($"{avgP3:f2}%");

        }
    }
}
