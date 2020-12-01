using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split();
            for (int i = letters.Length - 1; i >= 0; i--)
            {
                Console.Write($"{letters[i]} ");
            }
            Console.WriteLine();
        }
    }
}
