using System;
using System.Net;

namespace _2._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =  new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int j = numbers.Length - 1; j >= 0; j--)
            {
                Console.Write($"{numbers[j]} ");
            }
            Console.WriteLine();
        }
    }
}
