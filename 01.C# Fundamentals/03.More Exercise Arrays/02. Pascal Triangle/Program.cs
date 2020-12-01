using System;

namespace _1._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[] currArray = { 1 };

            for (int i = 1; i < numberOfRows; i++)
            {
                int[] newArray = new int[currArray.Length + 1];
                for (int j = 0; j < currArray.Length; j++)
                {
                    newArray[j] += currArray[j];
                    newArray[j + 1] += currArray[j];
                }
                Console.WriteLine(string.Join(' ',currArray));
                currArray = newArray;
            }
            Console.WriteLine(string.Join(' ',currArray));
        }
    }
}