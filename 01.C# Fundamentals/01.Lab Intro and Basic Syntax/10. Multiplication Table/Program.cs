using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum;

            for (int i = 1; i <= 10; i++)
            {
                sum = n * i;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
