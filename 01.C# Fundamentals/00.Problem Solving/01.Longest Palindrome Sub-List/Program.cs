using System;

namespace _01.Longest_Palindrome_Sub_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();

            int maxLen = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                maxLen = Math.Max(maxLen, PalidroneLen(letters, i, i));
            }
            for (int i = 0; i < letters.Length - 1; i++)
            {
                maxLen = Math.Max(maxLen, PalidroneLen(letters, i, i + 1));
            }

            Console.WriteLine(maxLen);
        }

        static int PalidroneLen(string letters, int leftIndex, int rigthIndex)
        {
            while (leftIndex >= 0 && rigthIndex < letters.Length && letters[leftIndex] == letters[rigthIndex])
            {
                leftIndex--;
                rigthIndex++;
            }
            return rigthIndex - leftIndex - 1;
        }
    }
    }
}
