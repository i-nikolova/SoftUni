using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morse = new Dictionary<string, char>()
                                   {
                                       { ".-",   'A'},
                                       {"-...", 'B' },
                                       {"-.-.", 'C' },
                                       {"-..",  'D' },
                                       {".",    'E' },
                                       {"..-.", 'F' },
                                       {"--.",  'G' },
                                       {"....", 'H' },
                                       {"..",   'I' },
                                       {".---", 'J' },
                                       {"-.-",  'K' },
                                       {".-..", 'L' },
                                       {"--",   'M' },
                                       {"-.",   'N' },
                                       {"---",  'O' },
                                       {".--.", 'P' },
                                       {"--.-", 'Q' },
                                       {".-.",  'R' },
                                       {"...",  'S' },
                                       {"-",    'T' },
                                       {"..-",  'U' },
                                       {"...-", 'V' },
                                       {".--",  'W' },
                                       {"-..-", 'X' },
                                       {"-.--", 'Y' },
                                       {"--..", 'Z' }
                                   };

            string[] words = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                string[] letters = words[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < letters.Length; j++)
                {
                    letters[j] = morse[letters[j]].ToString();
                }

                words[i] = string.Join("", letters);
            }

            Console.WriteLine(string.Join(" ",words));

        }
    }
}
