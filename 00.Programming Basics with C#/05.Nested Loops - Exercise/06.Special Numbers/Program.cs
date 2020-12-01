using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int countDevisio = 0;
                string currentNumber = i.ToString();
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());
                    if (currentDigit > 0)
                    {
                        if (n % currentDigit == 0)
                        {
                            countDevisio++;
                        }
                        if (countDevisio == 4)
                        {
                            Console.Write($"{currentNumber} ");
                        }
                    }

                }

            }
        }
    }
}
