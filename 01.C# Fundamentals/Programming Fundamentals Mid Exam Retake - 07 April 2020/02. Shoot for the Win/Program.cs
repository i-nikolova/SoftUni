using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = string.Empty;
            int countShotTargets = 0;
            while ((input=Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(input);
                if (targetIndex<0 || targetIndex>=target.Length || target[targetIndex]==-1)
                {
                    continue;
                }
                else
                {
                    countShotTargets++;
                    int indexValue = target[targetIndex];
                    for (int i = 0; i < target.Length; i++)
                    {
                        if (i== targetIndex)
                        {
                            target[i] = -1;
                        }
                        else
                        {
                            if (target[i]> indexValue && target[i]!=-1)
                            {
                                target[i] -= indexValue;
                            }
                            else if (target[i] <= indexValue && target[i] != -1)
                            {
                                target[i] += indexValue;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Shot targets: {countShotTargets} -> {string.Join(" ",target)}");
        }
    }
}
