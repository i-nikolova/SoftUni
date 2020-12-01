using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            bool Printed = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    count++;
                    if (count > n)
                    {
                        Printed = true;
                        break;
                    }
                    Console.Write(count + " ");
                }
                if (Printed)
                {
                    break;
                }
                Console.WriteLine();

            }
        }
    }
}
