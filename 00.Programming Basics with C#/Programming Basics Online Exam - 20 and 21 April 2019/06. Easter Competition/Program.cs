using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCake = int.Parse(Console.ReadLine());
            //string chefName = Console.ReadLine();
            int maxPoints = int.MinValue;
            //string input = Console.ReadLine();
            string winner = "";
            for (int i = 0; i < numberOfCake; i++)
            {
                string chefName = Console.ReadLine();
                string input = Console.ReadLine();
                int totalMarks = 0;
                
                while (input !="Stop")
                {
                    int mark = int.Parse(input);
                    totalMarks += mark;
                    input = Console.ReadLine();
                }
                Console.WriteLine($"{chefName} has {totalMarks} points.");
                if (totalMarks>maxPoints)
                {
                    maxPoints = totalMarks;
                    winner = chefName;
                    Console.WriteLine($"{chefName} is the new number 1!"); 
                }
            }
            Console.WriteLine($"{winner} won competition with {maxPoints} points!");
        }
    }
}
