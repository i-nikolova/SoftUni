using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<string> boughtItems = new List<string>();
            double totalPrice = 0;
            while ((input=Console.ReadLine())!="Purchase")
            {
                Regex regex = new Regex(@">>(?<furniture>\w+)<<(?<price>\d+.?\d*)!(?<qty>\d+)");
                if (regex.IsMatch(input))
                {
                    var item = regex.Match(input);
                    boughtItems.Add(item.Groups["furniture"].Value);
                    totalPrice += double.Parse(item.Groups["price"].Value) * double.Parse(item.Groups["qty"].Value);
                }

            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in boughtItems)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
