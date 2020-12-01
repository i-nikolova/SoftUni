using System;
using System.Linq;

namespace _4._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int foldedCount = array.Length / 2;
            int countFromStartAndEnd = foldedCount / 2;
            int[] rowOne = new int[foldedCount];
            int[] rowTwo = new int[foldedCount];
            int[] foldedArray = new int[foldedCount];

            
            for (int i = 1; i <= countFromStartAndEnd; i++)
            {
                rowOne[i-1] = array[countFromStartAndEnd-i];
            }
            for (int h = 1; h <= countFromStartAndEnd; h++)
            {
                rowOne[rowOne.Length - h] = array[array.Length - 1 - countFromStartAndEnd + h];
            }
            for (int k = 0; k < foldedCount; k++)
            {
                rowTwo[k] = array[countFromStartAndEnd + k];
            }

            for (int m = 0; m < foldedArray.Length; m++)
            {
                foldedArray[m] = rowOne[m] + rowTwo[m];
            }

            //Console.WriteLine(string.Join(' ',rowOne));
            //Console.WriteLine(string.Join(' ',rowTwo));
            Console.WriteLine(string.Join(' ', foldedArray));
        }
    }
}
