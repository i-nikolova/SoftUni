using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string substring = (Console.ReadLine()).ToLower();
            string word = Console.ReadLine();

            while (word.IndexOf(substring)!=-1)
            {
                word = word.Remove(word.IndexOf(substring), substring.Length);
            }

            Console.WriteLine(word);
        }
    }
}
