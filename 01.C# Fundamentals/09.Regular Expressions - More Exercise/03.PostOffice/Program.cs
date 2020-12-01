using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            Regex letters = new Regex(@"([#$%*&]{1})([A-Z]+)\1");
            string capitalLetters = string.Empty;
            Dictionary<char, int> words = new Dictionary<char, int>();

            if (letters.IsMatch(text[0]))
            {
                capitalLetters = letters.Match(text[0]).Groups[2].Value;
            }

            foreach (var ch in capitalLetters)
            {
                words.Add(ch, 0);
            }

            Regex length = new Regex(@"([\d]{2}):([\d]{2})");

            if (length.IsMatch(text[1]))
            {
                foreach (Match match in length.Matches(text[1]))
                {
                    int asciiNumber = int.Parse(match.Groups[1].Value);
                    int lengthNumber = int.Parse(match.Groups[2].Value);
                    if (words.ContainsKey((char)asciiNumber))
                    {
                        words[(char)asciiNumber] = lengthNumber + 1;
                    }
                }
            }

            string[] textToCheck = text[2].Split(" ", StringSplitOptions.RemoveEmptyEntries);

            /*for (int i = 0; i < textToCheck.Length; i++)
            {
                if (words.ContainsKey(textToCheck[i][0]))
                {
                    if (textToCheck[i].Length == words[textToCheck[i][0]])
                    {
                        Console.WriteLine(textToCheck[i]);
                    }
                }
            }*/

            foreach (var kvp in words.Keys)
            {
                for (int i = 0; i < textToCheck.Length; i++)
                {
                    if (textToCheck[i][0]==kvp)
                    {
                        if (textToCheck[i].Length == words[textToCheck[i][0]])
                        {
                            Console.WriteLine(textToCheck[i]);
                        }
                    }
                    
                }
            }

        }
    }
}
