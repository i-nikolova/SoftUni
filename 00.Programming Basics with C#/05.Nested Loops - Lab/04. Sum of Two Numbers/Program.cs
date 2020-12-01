using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            bool isFound = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combination++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({ i} + { j} = { magicNumber})");
                        isFound = true;
                        break;
                    }
                    
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }

        }
    }
}
