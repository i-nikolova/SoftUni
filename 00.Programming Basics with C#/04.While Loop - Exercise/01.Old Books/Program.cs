using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string fabBook = Console.ReadLine();
            string input = Console.ReadLine();
            int count = 0;
            bool isFound = false;
            while (input != "No More Books")
            {

                if (fabBook == input)
                {
                    isFound = true;
                    break;
                }

                count++;
                input = Console.ReadLine();

            }
            if (isFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {

                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
