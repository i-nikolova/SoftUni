using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine())!="Done")
            {
                string[] cmdArgs = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "Add Book":
                        CommandAdd(books, cmdArgs[1]);
                        break;
                    case "Take Book":
                        CommandTaka(books, cmdArgs[1]);
                        break;
                    case "Swap Books":
                        CommandSwap(books, cmdArgs[1], cmdArgs[2]);
                        break;
                    case "Insert Book":
                        CommandInsert(books, cmdArgs[1]);
                        break;
                    case "Check Book":
                        CommandCheck(books, int.Parse(cmdArgs[1]));
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine(string.Join(", ",books));
        }

        private static void CommandInsert(List<string> books, string bookName)
        {
                books.Add(bookName);
        }

        private static void CommandTaka(List<string> books, string bookName)
        {
            if (books.Contains(bookName))
            {
                books.Remove(bookName);
            }
        }

        private static void CommandSwap(List<string> books, string bookNameOne, string bookNameTwo)
        {
            if (books.Contains(bookNameOne) && books.Contains(bookNameTwo))
            {
                int bookOne = books.IndexOf(bookNameOne);
                int bookTwo = books.IndexOf(bookNameTwo);
                books[bookOne] = bookNameTwo;
                books[bookTwo] = bookNameOne;
            }
        }

        private static void CommandCheck(List<string> books, int index)
        {
            if (index>=0 && index <books.Count)
            {
                Console.WriteLine(books[index]);
            }
            
        }

        private static void CommandAdd(List<string> books, string bookName)
        {
            if (!books.Contains(bookName))
            {
                books.Insert(0,bookName);
            }
        }
    }
}
