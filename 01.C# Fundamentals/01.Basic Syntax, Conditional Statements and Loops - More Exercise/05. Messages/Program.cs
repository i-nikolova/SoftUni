using System;
using System.Globalization;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int clicks = int.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 0; i < clicks; i++)
            {
                string digits = Console.ReadLine();
                int numberOfdigits = digits.Length;
                int mainDigit = int.Parse(digits[0].ToString());

                int offset = (mainDigit - 2) * 3;
                if (mainDigit ==8 || mainDigit == 9)
                {
                    offset += 1;
                    int letterIndex = offset + (numberOfdigits - 1);
                    int letter = letterIndex + 97;
                    message += (char)letter;
                }
                else if (mainDigit == 0)
                {
                    message += ' ';
                }
                else
                {
                    int letterIndex = offset + (numberOfdigits - 1);
                    int letter = letterIndex + 97;
                    message += (char)letter;
                }
                
            }
            Console.WriteLine(message);

        }
    }
}
