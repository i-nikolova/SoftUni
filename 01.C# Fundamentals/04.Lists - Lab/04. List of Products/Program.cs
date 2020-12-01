using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i <= numberOfElements; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();

            for (int i = 1; i < products.Count; i++)
            {
                Console.WriteLine($"{i}.{products[i]}");
            }
        }
    }
}
