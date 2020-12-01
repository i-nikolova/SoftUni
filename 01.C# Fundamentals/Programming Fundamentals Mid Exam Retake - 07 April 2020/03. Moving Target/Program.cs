using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                if (command[0]=="Shoot")
                {
                    if (int.Parse(command[1])>=0 && int.Parse(command[1])<targets.Length)
                    {
                        targets = CommandShoot(targets, int.Parse(command[1]), int.Parse(command[2]));
                    }
                }
                else if (command[0] == "Add")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1])>=targets.Length)
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else
                    {
                        targets = CommandAdd(targets, int.Parse(command[1]), int.Parse(command[2]));
                    }
                }
                else
                {
                    int indexToLeft = int.Parse(command[1]) - int.Parse(command[2]);
                    int indexToRight = int.Parse(command[1]) + int.Parse(command[2]);
                    if (indexToLeft<0  ||  indexToRight >= targets.Length)
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    else
                    {
                        targets = CommandStrike(targets, int.Parse(command[1]), int.Parse(command[2]));
                    }
                }
            }
            Console.WriteLine(string.Join("|",targets));
        }

        static int[] CommandShoot (int[] targets,int index, int power)
        {
            List<int>  targetsList= new List<int>(targets);
            if (targetsList[index] - power<=0)
            {
                targetsList.RemoveAt(index);
            }
            else
            {
                targetsList[index] -= power;
            }
            return targetsList.ToArray();
        }
        static int[] CommandAdd(int[] targets, int index, int value)
        {
            List<int> targetsList = new List<int>(targets);
            targetsList.Insert(index, value);

            return targetsList.ToArray();
        }
        static int[] CommandStrike(int[] targets, int index, int radius)
        {
            List<int> targetsList = new List<int>(targets);
            int start = index - radius;
            int end = index + radius;
            targetsList.RemoveRange(start, end - start + 1);

            return targetsList.ToArray();
        }
    }
}
