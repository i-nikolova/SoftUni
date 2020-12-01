using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (comand=="add")
            {
                CalculationAdd(firstNumber, secondNumber);
            }
            else if (comand == "multiply")
            {
                CalculationMultiply(firstNumber, secondNumber);
            }
            else if (comand == "substract")
            {
                CalculationSubstract(firstNumber, secondNumber);
            }
            else
            {
                CalculationDevide(firstNumber, secondNumber);
            }
        }

        static void CalculationAdd(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }
        static void CalculationMultiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }
        static void CalculationSubstract(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }
        static void CalculationDevide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }
    }
}
