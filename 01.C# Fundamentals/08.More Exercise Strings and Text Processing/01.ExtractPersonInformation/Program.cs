using System;

namespace _01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();
                string name = line.Substring(line.IndexOf('@') + 1, line.IndexOf('|') - line.IndexOf('@')-1);
                string age = line.Substring(line.IndexOf('#') + 1, line.IndexOf('*') - line.IndexOf('#')-1);

                Console.WriteLine($"{name} is {age} years old.");

            }
        }
    }
}
