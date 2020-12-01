using System;
using System.Linq;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                int end = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = end;
            }
            
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write($"{arr[k]} ");
            }

        }
    }       
}
