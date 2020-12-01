using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers = int.Parse(Console.ReadLine());
            int evenSumm = 0;
            int oddSum = 0;
            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i%2 == 0)
                {
                    evenSumm += number;
                }
                else
                {
                    oddSum += number;   
                }
                               
            }

            if (evenSumm == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSumm}");
            }
            else
            {
                int difference = evenSumm - oddSum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(difference)}");
            }
        }
    }
}
