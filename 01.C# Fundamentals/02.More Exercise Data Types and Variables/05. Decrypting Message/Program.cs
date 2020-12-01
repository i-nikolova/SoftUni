using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int NumberOfLetters = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < NumberOfLetters; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int asciiNumberOfLetter = (int)letter+key;
                message += Convert.ToChar(asciiNumberOfLetter);
 }
            Console.WriteLine(message);
        }
    }
}
