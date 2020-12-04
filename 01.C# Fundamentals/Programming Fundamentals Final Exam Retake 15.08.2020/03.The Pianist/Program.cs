using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] piecesInfo = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = piecesInfo[0];
                string composer = piecesInfo[1];
                string key = piecesInfo[2];

                pieces.Add(piece, new List<string>() { composer, key });
            }

            string input = string.Empty;

            while ((input = Console.ReadLine())!="Stop")
            {
                string[] cmdArgs = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string piece = cmdArgs[1];

                if (command=="Add")
                {
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];
                    if (pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        pieces.Add(piece, new List<string>() { composer, key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }

                }
                else if (command=="Remove")
                {
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (command=="ChangeKey")
                {
                    string newKey = cmdArgs[1];
                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

            }

            foreach (var piece in pieces.OrderBy(x=>x.Key).ThenBy(x=>x.Value[1]))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
