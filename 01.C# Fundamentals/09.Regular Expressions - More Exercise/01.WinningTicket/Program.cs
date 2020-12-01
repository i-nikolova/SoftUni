using System;
using System.Text.RegularExpressions;

namespace _01.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tickets.Length; i++)
            {
                tickets[i] = tickets[i].Trim();
            }

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length==20)
                {
                    Regex regex = new Regex(@"([\@\#\$\^]{6,10}).*?\1");
                    if (regex.IsMatch(tickets[i]))
                    {
                        char symbol = regex.Match(tickets[i]).Groups[0].Value[0];
                        if (regex.Match(tickets[i]).Groups[1].Value.Length!=10)
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {regex.Match(tickets[i]).Groups[1].Value.Length}{symbol}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {regex.Match(tickets[i]).Groups[1].Value.Length}{symbol} Jackpot!");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
                
            }
        }
    }
}
