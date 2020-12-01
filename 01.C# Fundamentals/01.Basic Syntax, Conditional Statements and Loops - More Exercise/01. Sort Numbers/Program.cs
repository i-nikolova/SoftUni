using System;
using System.Reflection.PortableExecutable;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int maxNumer = int.MinValue;
            int minNumer = int.MaxValue;
            int middleNumber = 0;

            if (n1>n2 && n1>n3)
            {
                maxNumer = n1;
            }
            else if (n2>n1 && n2>n3)
            {
                maxNumer = n2;
            }
            else if (n3>n1 && n3>n2)
            {
                maxNumer = n3;
            }
            if (n1 < n2 && n1 < n3)
            {
                minNumer = n1;
            }
            else if (n2 < n1 && n2 < n3)
            {
                minNumer = n2;
            }
            else if (n3 < n1 && n3 < n2)
            {
                minNumer = n3;
            }
            if (n1>n2 && n1<n3)
            {
                middleNumber = n1;
            }
            else if (n1 < n2 && n1 > n3)
            {
                middleNumber = n1;
            }
            if (n2>n1 && n2<n3)
            {
                middleNumber = n2;
            }
            else if (n2>n3 && n2<n1)
            {
                middleNumber = n2;
            }
            if (n3>n1 && n3<n2)
            {
                middleNumber = n3;
            }
            else if (n3>n2 && n3<n1)
            {
                middleNumber = n3;
            }
            if (n1==n2 && n2==n3 && n1==n3 )
            {
                maxNumer = n1;
                minNumer = n2;
                middleNumber = n3;
            }
            else if (n1==n2 && n3>n1 && n3>n2)
            {
                maxNumer = n3;
                middleNumber = n1;
                minNumer = n2;
            }
            else if (n2 == n3 && n1 > n3 && n1 > n3)
            {
                maxNumer = n1;
                middleNumber = n2;
                minNumer = n3;
            }
            else if (n1 == n3 && n2 > n1 && n2 > n3)
            {
                maxNumer = n2;
                middleNumber = n1;
                minNumer = n3;
            }


            Console.WriteLine(maxNumer);
            Console.WriteLine(middleNumber);
            Console.WriteLine(minNumer);
            

        }
    }
}
