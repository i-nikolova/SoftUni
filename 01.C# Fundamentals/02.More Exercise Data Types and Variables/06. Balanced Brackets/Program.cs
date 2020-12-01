using Microsoft.VisualBasic;
using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            bool openedBracket = false;
            bool isBalanced = true;
            
            for (int i = 1; i <= numberOfRows; i++)
            {
                string input = Console.ReadLine();
                if (input=="(")
                {
                    openedBracket = true;
                    isBalanced = false;
                }
                
                if (input==")")
                {
                    isBalanced = true;
                    openedBracket = false;
                }
            }
            if (isBalanced && !openedBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
