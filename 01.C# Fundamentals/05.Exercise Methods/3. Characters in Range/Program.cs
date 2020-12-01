using System;

namespace _3._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            RangeOfCharacters(first, second);
        }

        static void RangeOfCharacters(char start, char end)
        {
            if ((int)start<(int)end)
            {
                for (int i = (int)start + 1; i < (int)end; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = (int)end + 1; i < (int)start; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            
        }
    }
}
