using System;
using System.Linq;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr= new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            SmallestNumber(arr);
        }

        static void SmallestNumber(int[] arr)
        {
            Console.WriteLine(arr.Min());
        }
    }
}
