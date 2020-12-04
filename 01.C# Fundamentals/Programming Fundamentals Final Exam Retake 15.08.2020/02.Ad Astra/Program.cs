using System;
using System.Text.RegularExpressions;

namespace Problem_2.Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#|])(?<item>[A-Za-z ]+)\1(?<expireDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

            MatchCollection matches = Regex.Matches(Console.ReadLine(), pattern);

            int totalCalories = 0;

            for (int i = 0; i < matches.Count; i++)
            {
                totalCalories += int.Parse(matches[i].Groups["calories"].Value);
            }

            Console.WriteLine($"You have food to last you for: {totalCalories/2000} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["item"].Value}, " +
                    $"Best before: {match.Groups["expireDate"].Value}, " +
                    $"Nutrition: {match.Groups["calories"].Value}");
            }

        }
    }
}
