using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int extensionIndex = input.IndexOf('.');
            string extension = input.Substring(extensionIndex+1, input.Length-1 - extensionIndex);
            int fileNameIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='\\')
                {
                    fileNameIndex = i;
                }

            }

            string fileName = input.Substring(fileNameIndex+1, extensionIndex-1-fileNameIndex);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
