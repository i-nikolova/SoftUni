using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToRepeat = Console.ReadLine();
            StringBuilder textToPrint = new StringBuilder();
            int uniqueSymbols = 0;


            Regex regex = new Regex(@"([^\d]+)(\d+)");

            if (regex.IsMatch(textToRepeat))
            {
                var matches = regex.Matches(textToRepeat);
                foreach (Match item in matches)
                {
                    string text = item.Groups[1].Value;
                    int times = int.Parse(item.Groups[2].Value);
                    for (int i = 0; i < times; i++)
                    {
                        textToPrint.Append(text.ToUpper());
                    }
                }
            }

            foreach (var ch in textToPrint.ToString().Distinct())
            {
                if (!char.IsDigit(ch))
                {
                    uniqueSymbols++;
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(textToPrint.ToString());
        }
    }
}
