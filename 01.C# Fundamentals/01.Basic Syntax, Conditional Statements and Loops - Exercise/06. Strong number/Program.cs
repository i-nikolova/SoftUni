using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int sum = 0;
            int imputNumber = int.Parse(n);

            for (int i = 0; i < n.Length; i++)
            {
                int fact = 1;
                int currentDigit = int.Parse(n[i].ToString());
                for (int j = 1; j <= currentDigit; j++)
                {
                    fact *= j;
                }
                sum += fact;
            }
            if (sum == imputNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
