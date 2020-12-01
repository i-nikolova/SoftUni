using System;

namespace _4._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                char letter =Convert.ToChar(Console.ReadLine());
                int asciiNumber = (int)letter;
                sum += asciiNumber;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
