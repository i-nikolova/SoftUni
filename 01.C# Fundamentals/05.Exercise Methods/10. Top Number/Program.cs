using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (CheckIfItHasOddDigit(i)==true && CheckSumDevisibleByEight(i)==true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckSumDevisibleByEight(int number)
        {
            int sum = 0;
            string numberToText = number.ToString();
            for (int i = 0; i < numberToText.Length; i++)
            {
                sum += int.Parse(numberToText[i].ToString());
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckIfItHasOddDigit(int number)
        {
            int sum = 0;
            string numberToText = number.ToString();
            bool isOdd = false;
            for (int i = 0; i < numberToText.Length; i++)
            {
                if (int.Parse(numberToText[i].ToString()) % 2 ==1)
                {
                    isOdd = true;
                    break;
                }
            }
            if (isOdd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
