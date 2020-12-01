using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower()).ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
            foreach (var pair in dict)
            {
                if (pair.Value %2 !=0)
                {
                    Console.Write($"{pair.Key} ");
                }
            }
        }
    }
}
