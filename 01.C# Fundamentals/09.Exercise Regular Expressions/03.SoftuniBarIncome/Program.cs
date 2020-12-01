using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03.SoftuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();

            string input = string.Empty;

            while ((input = Console.ReadLine())!="end of shift")
            {
                Regex regex = new Regex(@"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$");

                if (regex.IsMatch(input))
                {
                    string name = regex.Match(input).Groups["customer"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    double totalPrice = double.Parse(regex.Match(input).Groups["count"].Value) * double.Parse(regex.Match(input).Groups["price"].Value);

                    if (orders.ContainsKey(name))
                    {
                        orders[name] += totalPrice;
                    }
                    else
                    {
                        orders.Add(name, totalPrice);
                    }

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {orders.Values.Sum():f2}");
        }
    }
}
