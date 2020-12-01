using System;

namespace _11.Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secont = double.Parse(Console.ReadLine());

            Console.WriteLine(Operations(first,secont,operation));

        }

        static double Operations (double first,double second,string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "/":
                    result = first / second;
                    break;
                case "*":
                    result = first * second;
                    break;
                default:
                    break;
            }
            return result;
        }

    }
}
