using System;
using System.Linq;

namespace _8._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1+i; j <= array.Length-1; j++)
                {
                    sum = array[i] + array[j];
                    if (sum == magicSum)
                    {
                        Console.Write($"{array[i]} {array[j]}");
                        Console.WriteLine();
                    }
                }
                
            }
            
        }
    }
}
