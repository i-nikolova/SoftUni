using System;
using System.Linq;

namespace _5._Longest_Increasing_Subsequence__LIS_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] LIS ;
            int[] len = new int[array.Length];
            int[] prev = new int[array.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[i] && len[j]>=len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j;
                    }
                }
                if (len[i]>maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }
            LIS = new int[maxLength];
            for (int k = 0; k < maxLength; k++)
            {
                LIS[k] = array[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(LIS);
            Console.WriteLine(string.Join(' ',LIS));
            
        }
    }
}
