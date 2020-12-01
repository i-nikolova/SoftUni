using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = 0;
            while (input !=0)
            {
                result += input % 10;
                input /= 10;
            }
            Console.WriteLine(result);
            
        }
    }
}
