using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsinaString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (var word in words)
            {
                char[] wordChars = word.ToArray();
                foreach (var ch in wordChars)
                {
                    if (charCount.ContainsKey(ch))
                    {
                        charCount[ch]++;
                    }
                    else
                    {
                        charCount.Add(ch, 1);
                    }
                }
            }
            foreach (var pair in charCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
