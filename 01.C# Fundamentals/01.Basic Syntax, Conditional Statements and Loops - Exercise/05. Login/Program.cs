using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string paswordTry = Console.ReadLine();
            string password = "";
            bool loggedIn = false;
            bool isBlocked = false;
            int countTries = 0;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }
            while (true)
            {
                countTries++;
                if (countTries > 3)
                {
                    isBlocked = true;
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                if (paswordTry == password)
                {
                    loggedIn = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                paswordTry = Console.ReadLine();
            }
            if (loggedIn)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
