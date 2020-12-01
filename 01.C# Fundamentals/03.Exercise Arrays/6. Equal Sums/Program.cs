using System;
using System.Linq;

namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = false;
            for (int i = 0; i < array.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int j = i+1; j < array.Length; j++)
                {
                    sumRight += array[j];
                }
                for (int k = i - 1; k >= 0; k--)
                {
                    sumLeft += array[k];
                }
                if (sumLeft==sumRight)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                    break;
                }
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
