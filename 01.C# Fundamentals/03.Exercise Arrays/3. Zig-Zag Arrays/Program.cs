using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrNumbers = int.Parse(Console.ReadLine());
            int[] array1 = new int[arrNumbers];
            int[] array2 = new int[arrNumbers];
            int rowCount = 0;
            for (int i = 1; i <= arrNumbers; i++)
            {

                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i % 2 != 0 && j==0)
                    {
                        array1[rowCount] = arr[j];
                    }
                    else if (i % 2 != 0 && j == 1)
                    {
                        array2[rowCount] = arr[j];
                    }
                    else if (i % 2 == 0 && j == 1)
                    {
                        array1[rowCount] = arr[j];
                    }
                    else
                    {
                        array2[rowCount] = arr[j];
                    }
                }
                rowCount++;

            }
            for (int k = 0; k < array1.Length; k++)
            {
                Console.Write($"{array1[k]} ");
            }
            Console.WriteLine();
            for (int l = 0; l < array2.Length; l++)
            {
                Console.Write($"{array2[l]} ");
            }
        }
    }
}
