using System;
using System.Runtime.Versioning;
using System.Threading;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int countChanges = 0;
            for (int i = k; i <= 8; i++)
            {
                for (int j = 9; j >= l; j--)
                {
                    for (int o = m; o <= 8; o++)
                    {
                        for (int p = 9; p >= n; p--)
                        {
                           
                        }

                        if (i % 2 == 0 && j % 2 != 0 && o % 2 == 0 && p % 2 != 0)
                        {
                            if (i == o && j == p)
                            {
                                Console.WriteLine($"Cannot change the same player.");
                            }
                            else
                            {
                                Console.WriteLine($"{i}{j} - {o}{p}");
                                countChanges++;
                                if (countChanges == 6)
                                {
                                    Environment.Exit(0);
                                }
                            }

                        }
                    }
                }
            }
        }

    }
}

