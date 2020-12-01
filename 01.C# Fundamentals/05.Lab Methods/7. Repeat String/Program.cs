using System;
using System.Text;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string newText = RepeatingString(text, count);
            Console.WriteLine(newText);

        }

        static string RepeatingString(string text, int timesRepeating)
        {
            string newText = string.Empty;
            for (int i = 0; i < timesRepeating; i++)
            {
                newText += text;
            }
            return newText;
        }
    }
}
