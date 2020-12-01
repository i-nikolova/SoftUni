using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            BigInteger threshold = 1;
           Dictionary<string, int> emojiList = new Dictionary<string, int>();

            Regex digits = new Regex(@"[\d]");

            if (digits.IsMatch(text))
            {
                
                foreach (Match match in digits.Matches(text))
                {
                    threshold *= int.Parse(match.ToString());
                }
            }

            Regex emoji = new Regex(@"(?<symbols>[:]{2}|[*]{2})(?<name>[A-Z][a-z]{2,})\1");

            if (emoji.IsMatch(text))
            {
                foreach (Match match in emoji.Matches(text))
                {
                    int coolnes = 0;
                    foreach (char ch in match.ToString() )
                    {
                        if (char.IsLetter(ch))
                        {
                            coolnes += ch;
                        }
                    }
                    emojiList.Add(match.ToString(), coolnes);
                }

            }

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojiList.Keys.Count} emojis found in the text. The cool ones are:");

            foreach (var item in emojiList)
            {
                if (item.Value>=threshold)
                {
                    Console.WriteLine(item.Key);
                }
            }
           
            //([*:]{2})([A-Z][a-z]{2,})\1
        }
    }
}
