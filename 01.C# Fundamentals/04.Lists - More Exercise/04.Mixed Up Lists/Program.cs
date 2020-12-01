using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _04.Mixed_Up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> resultList = new List<int>();

            for (int i = 0; i < Math.Max(listOne.Count,listTwo.Count); i++)
            {
                if (i<listOne.Count)
                {
                    resultList.Add(listOne[i]);
                }
                if (listTwo.Count - 1 - i >= 0)
                {
                    resultList.Add(listTwo[listTwo.Count - 1 - i]);
                }
                
            }

            int maxNumber = Math.Max(resultList[resultList.Count - 1], resultList[resultList.Count - 2]);
            int minNumber = Math.Min(resultList[resultList.Count - 1], resultList[resultList.Count - 2]);
            resultList.RemoveAt(resultList.Count - 1);
            resultList.RemoveAt(resultList.Count - 1);

            resultList = resultList.Where(element => element > minNumber).ToList();
            resultList = resultList.Where(element => element < maxNumber).ToList();

            resultList.Sort();
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
