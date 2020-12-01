using System;

namespace _5._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            MultiplicationSing(n1,n2,n3);
        }

        static void MultiplicationSing (int n1,int n2, int n3)
        {
            int countNegatives = 0;
            if (n1<0)
            {
                countNegatives++;
            }
            if (n2<0)
            {
                countNegatives++;
            }
            if (n3<0)
            {
                countNegatives++;
            }
            if (n1==0||n2==0||n3==0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (countNegatives % 2 == 0)
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }
            
        }
    }
}
