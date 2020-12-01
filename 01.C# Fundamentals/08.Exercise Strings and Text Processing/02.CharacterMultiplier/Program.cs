using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string str1 = input[0];
            string str2 = input[1];
            int sum = 0;
            for (int i = 0; i < Math.Max(str1.Length,str2.Length); i++)
            {
                if (i<= Math.Min(str1.Length-1, str2.Length-1))
                {
                    sum += (int)str1[i] * (int)str2[i];
                }
                else
                {
                    if (str1.Length>str2.Length)
                    {
                        sum += str1[i];
                    }
                    else
                    {
                        sum += str2[i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
