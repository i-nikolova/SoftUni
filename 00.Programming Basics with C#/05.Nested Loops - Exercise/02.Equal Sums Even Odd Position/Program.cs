using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int even = 0;
                int odd = 0;
                string currentNumber = i.ToString();
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentPosition = int.Parse(currentNumber[j].ToString());
                    if (j % 2 == 0)
                    {
                        even += currentPosition;
                    }
                    else
                    {
                        odd += currentPosition;
                    }
                }
                if (even == odd)
                {
                    Console.Write($"{currentNumber} ");
                }


            }

        }
    }
}


