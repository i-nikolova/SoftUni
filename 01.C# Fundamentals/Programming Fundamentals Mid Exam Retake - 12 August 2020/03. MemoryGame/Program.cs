using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            bool isWinner = false;
            string input = string.Empty;
            int movesCount = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                int[] inputArr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                movesCount++;
                if (inputArr[0] < 0 || inputArr[0] >= arr.Length || inputArr[1] < 0 || inputArr[1] >= arr.Length)
                {
                    string[] arr1 = new string[arr.Length + 2];

                    arr1[(arr1.Length / 2) - 1] = $"-{movesCount}a";
                    arr1[(arr1.Length / 2)] = $"-{movesCount}a";
                    for (int j = 0; j < arr1.Length / 2 - 1; j++)
                    {
                        arr1[j] = arr[j];
                    }

                    for (int i = arr.Length / 2; i < arr.Length; i++)
                    {
                        arr1[i + 2] = arr[i];
                    }

                    arr = arr1;
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (arr[inputArr[0]] == arr[inputArr[1]])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {arr[inputArr[0]]}!");
                        if (arr.Length == 2)
                        {
                            Console.WriteLine($"You have won in {movesCount} turns!");
                            isWinner = true;
                            break;
                        }
                        else
                        {
                            List<string> arrList = new List<string>(arr);

                            if (inputArr[0] > inputArr[1])
                            {
                                arrList.RemoveAt(inputArr[0]);
                                arrList.RemoveAt(inputArr[1]);
                            }
                            else
                            {
                                arrList.RemoveAt(inputArr[1]);
                                arrList.RemoveAt(inputArr[0]);
                            }
                            arr = arrList.ToArray();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
            }
            if (!isWinner)
            {
                Console.WriteLine($"Sorry you lose :(\n" +
                    $"{string.Join(' ', arr)}");
            }
        }
    }
}
