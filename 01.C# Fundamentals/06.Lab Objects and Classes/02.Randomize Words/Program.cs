using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Random rnd = new Random();

            for (int i = 0; i < input.Count; i++)
            {
                int newPosition = rnd.Next(0, input.Count - 1);
                string currentWord = input[i];
                input[i] = input[newPosition];
                input[newPosition] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
