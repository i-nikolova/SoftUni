using System;

namespace _3._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacciNumber = int.Parse(Console.ReadLine());
            int[] newFibonacci = new int[fibonacciNumber];
            for (int i = 0; i < fibonacciNumber; i++)
            {
                
                if (i == 0 || i== 1)
                {
                    newFibonacci[i] = 1;
                }
                else
                {
                    newFibonacci[i] = newFibonacci[i - 1] + newFibonacci[i - 2];
                }
            }
            Console.WriteLine(newFibonacci[newFibonacci.Length-1]);
            
        }
    }
}
