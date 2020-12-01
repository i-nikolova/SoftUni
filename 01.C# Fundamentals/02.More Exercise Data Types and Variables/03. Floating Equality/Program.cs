using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            if (n1 < n2)
            {
                double temp = n1;
                n1 = n2;
                n2 = temp;
            }

            if (n1 - n2 < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
