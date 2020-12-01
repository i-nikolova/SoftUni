using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int maxCounter = 0;
            int startPosition = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i+1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        startPosition = i - counter;
                    }

                }
                else
                {
                    counter = 0;
                }
                
            }
            for (int i = startPosition+1; i <= startPosition+maxCounter+1; i++)
            {
                Console.Write($"{array[i]} ");
            }

        }
    }
}
