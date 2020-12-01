using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;
            while (n != "stop")
            {
                int countPrime = 0;
                int number = int.Parse(n);
                if (number >= 0)
                {
                    for (int i = 2; i < number + 1; i++)
                    {
                        if (number % i == 0)
                        {
                            countPrime++;
                        }
                    }
                    if (countPrime == 1)
                    {
                        sumPrime += number;
                    }
                    else
                    {
                        sumNonPrime += number;
                    }
                }
                else
                {
                    Console.WriteLine("Number is negative.");
                }

                n = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: { sumNonPrime}");

        }
    }
}
