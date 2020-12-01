using System;
using System.Threading;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string operator1 = Console.ReadLine();
            double result = 0;

            switch (operator1)
            {
                case "+":
                    result = number1 + number2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operator1} {number2} = {result:f0} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operator1} {number2} = {result:f0} - odd");
                    }
                    break;
                case "-":
                    result = number1 - number2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operator1} {number2} = {result:f0} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operator1} {number2} = {result:f0} - odd");
                    }
                    break;
                case "*":
                    result = number1 * number2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operator1} {number2} = {result:f0} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operator1} {number2} = {result:f0} - odd");
                    }
                    break;
                case "/":
                    if (number2 !=0)
                    {
                        result = number1 / number2;
                        Console.WriteLine($"{number1} {operator1} {number2} = {result:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                     break;
                case "%":
                    if (number2 != 0)
                    {
                        result = number1 % number2;
                        Console.WriteLine($"{number1} {operator1} {number2} = {result:f0}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    break;
                default:
                    break;
            }


        }
    }
}
