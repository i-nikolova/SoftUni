using System;
using System.Xml.Schema;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetSumOfDigits(int number,int isOdd)
        {
            string n = number.ToString();
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int currentDigit = int.Parse(n[i].ToString());
                if (currentDigit % 2 == isOdd)
                {
                    sum += currentDigit;
                }
                
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfDigits(number, 1) * GetSumOfDigits(number, 0);
        }


    }
}
