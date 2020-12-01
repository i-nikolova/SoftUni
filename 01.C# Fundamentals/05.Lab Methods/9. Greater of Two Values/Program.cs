using System;
using System.Threading;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            
            if (type == "int")
            {
                Console.WriteLine(GetMax(int.Parse(first), int.Parse(second))); 
            }
            else if (type == "char")
            {
                Console.WriteLine(GetMax(char.Parse(first), char.Parse(second))); ;
            }
            else
            {
                Console.WriteLine(GetMax(first, second));
            }

        }

        static int GetMax(int first, int second)
        {
            int result = first.CompareTo(second);
            if (result == 1)
            {
                return first;
            }
            else
            {
                return second;
            }
            
        }
        static string GetMax(string firstNumber, string secondNumber)
        {
            int result = firstNumber.CompareTo(secondNumber);
            if (result == 1)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        static char GetMax(char firstNumber, char secondNumber)
        {
            int result = firstNumber.CompareTo(secondNumber);
            if (result == 1)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
            
        }
    }
}
