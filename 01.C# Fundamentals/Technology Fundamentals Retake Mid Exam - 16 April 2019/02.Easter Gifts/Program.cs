using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;
            while ((input= Console.ReadLine())!="No Money")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "OutOfStock":
                        CommandOutOfStock(gifs,cmdArgs[1]);
                        break;
                    case "Required":
                        CommandRequired(gifs, cmdArgs[1],int.Parse(cmdArgs[2]));
                        break;
                    case "JustInCase":
                        CommandJustInCase(gifs, cmdArgs[1]);
                        break;
                    default:
                        break;
                }
            }
            gifs = gifs.Where(x => x != "None").ToList();
            Console.WriteLine(string.Join(" ",gifs));
        }

        private static void CommandJustInCase(List<string> gifs, string gift)
        {
            gifs[gifs.Count-1] = gift;
        }

        private static void CommandRequired(List<string> gifs, string gift, int index)
        {
            if (index>=0 && index<gifs.Count)
            {
                gifs[index] = gift;
            }
            
        }

        private static void CommandOutOfStock(List<string> gifs, string gift)
        {
            if (gifs.Contains(gift))
            {
                for (int i = 0; i < gifs.Count; i++)
                {
                    if (gifs[i]==gift)
                    {
                        gifs[i] = "None";
                    }
                }
            }
        }
    }
}
