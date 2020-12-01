using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            List<int> initialList = drums.ToList();

            while((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int power = int.Parse(input);
                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= power;
                    if (drums[i]<=0)
                    {
                        if ((initialList[i]) * 3<=budget)
                        {
                            budget -=  (initialList[i])* 3;
                            drums[i] = initialList[i];
                        }
                        else
                        {
                            initialList.RemoveAt(i);
                            drums.RemoveAt(i--);
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ", drums));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }
    }
}
