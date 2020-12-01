using System;
using System.Linq;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                CheckIfPalindrome(input);
            }
        }

        static void CheckIfPalindrome(string input)
        {
            char[] tempArr = input.ToCharArray().Reverse().ToArray();
            string reversedString = string.Join("", tempArr);
                if (input == reversedString)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }

