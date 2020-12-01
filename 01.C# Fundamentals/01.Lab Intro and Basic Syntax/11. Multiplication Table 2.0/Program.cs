using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum;
            if (end >10)
            {
                sum = n * end;
                Console.WriteLine($"{n} X {end} = {sum}");
            }
            else
            {
                for (int i = end; i <= 10; i++)
                {
                    sum = n * i;
                    Console.WriteLine($"{n} X {i} = {sum}");
                }
            }
            
        }
    }
}
