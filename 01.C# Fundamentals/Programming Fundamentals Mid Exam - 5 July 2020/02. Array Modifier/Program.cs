using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input.Split();
                if (inputArr[0] == "swap")
                {
                    SwapArray(array, int.Parse(inputArr[1]), int.Parse(inputArr[2]));
                }
                else if (inputArr[0] == "multiply")
                {
                    MultyplyArray(array, int.Parse(inputArr[1]), int.Parse(inputArr[2]));
                }
                else
                {
                    Descrease(array);
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }

        static void SwapArray(int[] array, int index1, int index2)
        {
            int element1 = array[index1];
            int element2 = array[index2];
            array[index1] = element2;
            array[index2] = element1;
        }
        static void MultyplyArray(int[] array, int index1, int index2)
        {
            array[index1] = array[index1] * array[index2];
        }
        static void Descrease(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= 1;
            }
        }
    }
}
