using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).OrderBy(n => n).ToList();
            Dictionary<double, int> dict = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict.Add(number, 1);
                }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
