using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string passwordTry = Console.ReadLine();

            while (password !=passwordTry)
            {
                passwordTry = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");

        }
    }
}
