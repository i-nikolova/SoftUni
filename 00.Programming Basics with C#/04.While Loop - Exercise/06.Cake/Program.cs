using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int cakeSize = height * weight;
            string input = Console.ReadLine();

            while (input != "STOP")
            {

                int pisces = int.Parse(input);
                cakeSize -= pisces;
                if (cakeSize <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {cakeSize * -1} pieces more.");
                    break;
                }
                input = Console.ReadLine();


            }
            if (cakeSize > 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }




        }
    }
}
