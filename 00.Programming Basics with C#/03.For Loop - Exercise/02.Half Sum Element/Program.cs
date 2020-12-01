using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number>maxNumber)
                {
                    maxNumber = number;
                }
            }
            int sumWithoutMaxnumber = sum - maxNumber;
            if (sumWithoutMaxnumber==maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = "+maxNumber);
            }
            else
            {
                int diff = Math.Abs(maxNumber - sumWithoutMaxnumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " +diff);
            }
        }
    }
}
