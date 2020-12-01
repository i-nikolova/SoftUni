using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> summedList = new List<double>();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                summedList.Add(numbers[i] + numbers[numbers.Count - i - 1]);
            }
            if (numbers.Count%2==1)
            {
                summedList.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", summedList));
        }
    }
}
