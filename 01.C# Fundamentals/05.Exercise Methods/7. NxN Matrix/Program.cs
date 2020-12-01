using System;

namespace _7._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
            
        }

        static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                PrintLine(n);
                Console.WriteLine();
            }
            
        }
        static void PrintLine(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
