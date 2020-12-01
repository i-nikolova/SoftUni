using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];
                char firstLetter = curr[0];
                char lastLetter = curr[curr.Length - 1];
                double number = double.Parse(curr.Substring(1, curr.Length - 2));

                if ((int)firstLetter>=65 && (int)firstLetter <=90)
                {
                    if (number!=0)
                    {
                        number =number / (alpha.IndexOf(char.ToUpper(firstLetter)) + 1);

                    }
                }
                else
                {
                    number= number * (alpha.IndexOf(char.ToUpper(firstLetter))+1);
                }

                if ((int)lastLetter >= 65 && (int)lastLetter <= 90)
                {
                    number= number - (alpha.IndexOf(char.ToUpper(lastLetter))+1);
                }
                else
                {
                    number= number + (alpha.IndexOf(char.ToUpper(lastLetter))+1);
                }

                result += number;

            }

            Console.WriteLine($"{result:f2}");

        }
    }
}
