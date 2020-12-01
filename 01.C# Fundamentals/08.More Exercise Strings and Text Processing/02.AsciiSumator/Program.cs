using System;
using System.ComponentModel;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            int char1 = (int)char.Parse(Console.ReadLine());
            int char2 = (int)char.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if ((int)line[i]>char1 && (int)line[i]<char2)
                {
                    sum += (int)line[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
