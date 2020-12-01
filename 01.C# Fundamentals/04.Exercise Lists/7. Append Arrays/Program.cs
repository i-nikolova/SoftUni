using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split("|").ToList();
            numbers.Reverse();
            StringBuilder stringArray = new StringBuilder();
            foreach (string item in numbers)
            {
                stringArray.Append(item+" ");
            }
            List<int> finalNumbers = stringArray.ToString().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", finalNumbers));

        }
    }
}
