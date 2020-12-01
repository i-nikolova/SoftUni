using System;
using System.Threading;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int asciiNumber = (int) Convert.ToChar(input);
            if (asciiNumber >=97 && asciiNumber<=122)
            {
                Console.WriteLine("lower-case");
                
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}