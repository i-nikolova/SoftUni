using System;
using System.Transactions;

namespace _4._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", Tribonacci(n)));
        }

        static int[] Tribonacci(int n)
        {
            int[] tribonacci = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    tribonacci[i] = 1;
                }
                else if (i == 1)
                {
                    tribonacci[i] = 1;
                }
                else if (i == 2)
                {
                    tribonacci[i] = 2;
                }
                else
                {
                    tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
                }
            }
            return tribonacci;
        }
    }
}
