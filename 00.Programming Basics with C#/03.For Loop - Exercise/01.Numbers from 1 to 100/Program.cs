using System;

namespace Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum += number;
            }
            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum += number; 
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int difference = leftSum - rightSum;
                Console.WriteLine($"No, diff = {Math.Abs(difference)}");
            }
        }
    }
}
