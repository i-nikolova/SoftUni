using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\+359([ -])2\1(\d{3})\1(\d{4})\b");

            MatchCollection phones = regex.Matches(input);

            string[] matchedPhones = phones.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
