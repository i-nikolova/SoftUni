using System;
using System.Linq;
using System.Text;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            if (array.Length == 1 || array.Distinct().Take(2).Count() == 1)
            {
                Console.WriteLine("No");
            }
            else
            {
                int[] graterNumber = GetGraterThanAvarage(array);
                if (graterNumber.Length < 5)
                {
                    Console.WriteLine(string.Join(" ", graterNumber));
                }
                else
                {
                    Console.WriteLine(string.Join(" ", GetTopFiveNumbers(graterNumber)));
                }

            }

        }
        static int[] GetGraterThanAvarage(int[] array)
        {
            double avg = array.Average();
            StringBuilder numberGreaterThanAvg = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > avg)
                {
                    numberGreaterThanAvg.Append($"{array[i]} ");
                }
            }

            int[] greatestNumbers = numberGreaterThanAvg
                              .ToString()
                              .Trim()
                              .Split()
                              .Select(int.Parse)
                              .ToArray();
            return greatestNumbers.OrderByDescending(greatestNumbers => greatestNumbers).ToArray();


        }
        static int[] GetTopFiveNumbers(int[] array)
        {
            int[] topFiveNumbers = new int[5];
            for (int i = 0; i < topFiveNumbers.Length; i++)
            {
                topFiveNumbers[i] = array[i];
            }
            return topFiveNumbers.OrderByDescending(topFiveNumbers => topFiveNumbers).ToArray();
        }
    }
}
