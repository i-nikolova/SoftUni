using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(SubstractNumbers(SumNumber(first,second),third));
        }

        static int SumNumber (int first,int second)
        {
            return first + second;
        }
        static int SubstractNumbers (int result,int third)
        {
            return result - third;
        }

    }
}
