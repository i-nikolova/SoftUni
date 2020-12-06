using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            List<string> kids = new List<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                StringBuilder text = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    int asciiNumber = (int)(char)input[i];
                    text.Append((char)(asciiNumber - key));
                }

                Regex regex = new Regex(@"@(?<name>[A-Za-z]+)[^@\-\!\:\>]*!(?<type>[GN])!");

                if (regex.IsMatch(text.ToString()))
                {
                    if (regex.Match(text.ToString()).Groups["type"].Value == "G")
                    {
                        kids.Add(regex.Match(text.ToString()).Groups["name"].Value);
                    }
                }
            }

            foreach (var kid in kids)
            {
                Console.WriteLine($"{kid}");
            }
        }
    }
}
