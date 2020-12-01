using System;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (i<input.Length-1 && input[i] == input[i + 1])
                {
                    input = input.Remove(i + 1,1);
                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
