using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Stop")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Delete":
                        CommandDelete(words, int.Parse(cmdArgs[1]));
                        break;
                    case "Swap":
                        CommandSwap(words, cmdArgs[1],cmdArgs[2]);
                        break;
                    case "Put":
                        CommandPut(words, cmdArgs[1], int.Parse(cmdArgs[2]));
                        break;
                    case "Sort":
                        CommandSort(words);
                        break;
                    case "Replace":
                        CommandReplace(words, cmdArgs[1], cmdArgs[2]);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", words));
        }

        private static void CommandReplace(List<string> words, string word1, string word2)
        {
            if (words.Contains(word2))
            {
                words[words.IndexOf(word2)] = word1;
            }
        }

        private static void CommandSort(List<string> words)
        {
            words.Sort();
            words.Reverse();
        }

        private static void CommandPut(List<string> words, string word, int index)
        {
            if (index >= 1 && index <= words.Count+1)
            {
                if (index==words.Count+1)
                {
                    words.Add(word);
                }
                else
                {
                    words.Insert(index - 1,word);
                }
                
            }

        }

        private static void CommandSwap(List<string> words, string word1, string word2)
        {
            if (words.Contains(word1)&& words.Contains(word2))
            {
                int indexWord1 = words.IndexOf(word1);
                int indexWord2 = words.IndexOf(word2);
                words[indexWord1] = word2;
                words[indexWord2] = word1;
            }
        }

        private static void CommandDelete(List<string> words, int index)
        {
            if (index+1>-1 && index+1 < words.Count)
            {
                words.RemoveAt(index + 1);
            }
        }
    }
}
