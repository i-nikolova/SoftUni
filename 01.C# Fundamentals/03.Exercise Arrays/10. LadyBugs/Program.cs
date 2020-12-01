using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] array = new int[arrSize];
            int[] ladyBugPosition = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < ladyBugPosition.Length; i++)
            {
                int indexMoving = ladyBugPosition[i];
                if (indexMoving>=0 && indexMoving <array.Length )
                {
                    array[indexMoving] = 1;
                }
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();
                int ladyBugIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flyLength = int.Parse(elements[2]);
                if (ladyBugIndex<0 || ladyBugIndex>array.Length-1 || array[ladyBugIndex]==0)
                {
                    continue;
                }

                array[ladyBugIndex] = 0;
                if (direction=="right")
                {
                    int landIndex = ladyBugIndex + flyLength;
                    if (landIndex>array.Length-1)
                    {
                        continue;
                    }
                    if (array[landIndex]==1)
                    {
                        while (array[landIndex]==1)
                        {
                            landIndex += flyLength;
                            if (landIndex>array.Length-1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= array.Length - 1)
                    {
                        array[landIndex] = 1;
                    }
                }
                else if (direction=="left")
                {
                    int landIndex = ladyBugIndex - flyLength;
                    if (landIndex < 0)
                    {
                        continue;
                    }
                    if (array[landIndex] == 1)
                    {
                        while (array[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= array.Length - 1)
                    {
                        array[landIndex] = 1;
                    }
                }
                
            }

            Console.WriteLine(string.Join(' ', array));

        }
    }
}
